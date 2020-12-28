using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Owoify
{
    internal class Word
    {
        private string _word;
        private readonly HashSet<string> _replacedWords = new HashSet<string>();

        public override string ToString() => _word;

        internal Word(string word)
        {
            _word = word;
        }

        internal Word Replace(Regex searchValue, string replaceValue, bool replaceReplacedWords = false)
        {
            if (!replaceReplacedWords && SearchValueContainsReplacedWords(searchValue, replaceValue, _replacedWords))
                return this;

            var replacingWord = _word;
            if (searchValue.IsMatch(_word))
                replacingWord = Regex.Replace(_word, searchValue.ToString(), replaceValue);

            return InnerReplace(searchValue, replaceValue, replacingWord);
        }

        internal Word Replace(Regex searchValue, Func<string> func, bool replaceReplacedWords = false)
        {
            var replaceValue = func.Invoke();

            if (!replaceReplacedWords && SearchValueContainsReplacedWords(searchValue, replaceValue, _replacedWords))
                return this;

            var replacingWord = _word;
            if (searchValue.IsMatch(_word))
            {
                var match = searchValue.Match(_word).Value;
                replacingWord = _word.Replace(match, replaceValue).Trim();
            }

            return InnerReplace(searchValue, replaceValue, replacingWord);
        }

        internal Word Replace(Regex searchValue, Func<string, string, string> func, bool replaceReplacedWords = false)
        {
            if (!searchValue.IsMatch(_word)) 
                return this;
            
            var match = searchValue.Match(_word);
            var replaceValue = func.Invoke(match.Groups[1].Value, match.Groups[2].Value);

            if (!replaceReplacedWords && SearchValueContainsReplacedWords(searchValue, replaceValue, _replacedWords))
                return this;

            var replacingWord = _word.Replace(match.Value, replaceValue).Trim();

            return InnerReplace(searchValue, replaceValue, replacingWord);
        }

        private Word InnerReplace(Regex searchValue, string replaceValue, string replacingWord)
        {
            var matchCollection = searchValue.Matches(_word);
            var replacedWords = GetReplacedWordsList(matchCollection, replaceValue);

            if (replacingWord == _word)
                return this;

            replacedWords.ForEach(word => _replacedWords.Add(word));
            _word = replacingWord;
            return this;
        }

        private static List<string> GetReplacedWordsList(MatchCollection matchCollection, string replaceValue)
        {
            return matchCollection.Any()
                ? matchCollection.Select(match => match.Value.Replace(match.Value, replaceValue)).ToList()
                : new List<string>();
        }

        private static bool SearchValueContainsReplacedWords(Regex searchValue, string replaceValue, IEnumerable<string> replacedWords)
        {
            return replacedWords.Any(word =>
            {
                if (searchValue.IsMatch(word))
                {
                    var match = searchValue.Match(word).Groups[0];
                    return word.Replace(match.Value, replaceValue) == word;
                }
                return false;
            });
        }
    }
}
