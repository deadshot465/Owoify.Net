﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Owoify
{
    internal class Word
    {
        private string _word;
        private readonly HashSet<string> _replacedWords = new HashSet<string>();

        public override string ToString()
            => _word;

        internal Word(string word)
        {
            _word = word;
        }

        internal Word Replace(Regex searchValue, string replaceValue, bool replaceReplacedWords = false)
        {
            if (!replaceReplacedWords &&
                SearchValueContainsReplacedWords(searchValue, replaceValue, _replacedWords))
                return this;

            string replacingWord;
            if (searchValue.IsMatch(_word))
                replacingWord = searchValue.Replace(_word, replaceValue);
            else return this;
#if NET7_0_OR_GREATER
            var enumerator = searchValue.EnumerateMatches(_word);
            while (enumerator.MoveNext())
            {
                _replacedWords.Add(replaceValue);
            }
#else
            var matchCollection = searchValue.Matches(_word);
            var replacedWords = (matchCollection.Count > 0) ?
                matchCollection.Select(x => x.Value)
                : Array.Empty<string>();
            foreach (var word in replacedWords)
            {
                _replacedWords.Add(word);
            }
#endif
            _word = replacingWord;
            return this;
        }

        internal Word Replace(Regex searchValue, Func<string> func, bool replaceReplacedWords = false)
        {
            var replaceValue = func.Invoke();

            if (!replaceReplacedWords &&
                SearchValueContainsReplacedWords(searchValue, replaceValue, _replacedWords))
                return this;

            var replacingWord = _word;
            if (searchValue.IsMatch(_word))
            {
                var match = searchValue.Match(_word).Value;
                replacingWord = _word.Replace(match, replaceValue).Trim();
            }

#if NET7_0_OR_GREATER
            var enumerator = searchValue.EnumerateMatches(_word);
            var replacedWords = new List<string>();
            while (enumerator.MoveNext())
            {
                replacedWords.Add(replaceValue);
            }
#else
            var matchCollection = searchValue.Matches(_word);
            var replacedWords = (matchCollection.Count > 0) ?
                matchCollection.Select(x => x.Value)
                : Array.Empty<string>();
#endif

            if (replacingWord != _word)
            {
                foreach (var word in replacedWords)
                {
                    _replacedWords.Add(word);
                }
                _word = replacingWord;
            }
            return this;
        }

        internal Word Replace(Regex searchValue, Func<string, string, string> func, bool replaceReplacedWords = false)
        {
            if (!searchValue.IsMatch(_word)) return this;
            
            var match = searchValue.Match(_word);
            var replaceValue = func.Invoke(match.Groups[1].Value, match.Groups[2].Value);

            if (!replaceReplacedWords &&
                SearchValueContainsReplacedWords(searchValue, replaceValue, _replacedWords))
                return this;
            
            var replacingWord = _word.Replace(match.Value, replaceValue).Trim();
            if (replacingWord == _word) return this;

#if NET7_0_OR_GREATER
            var enumerator = searchValue.EnumerateMatches(_word);
            while (enumerator.MoveNext())
            {
                _replacedWords.Add(replaceValue);
            }
#else
            var matchCollection = searchValue.Matches(_word);
            var replacedWords = (matchCollection.Count > 0) ?
                matchCollection.Select(x => x.Value)
                : Array.Empty<string>();
            foreach (var word in replacedWords)
            {
                _replacedWords.Add(word);
            }
#endif

            _word = replacingWord;
            return this;
        }

        private static bool SearchValueContainsReplacedWords(Regex searchValue, string replaceValue,
            IEnumerable<string> replacedWords)
        {
            foreach (var word in replacedWords)
            {
                if (!searchValue.IsMatch(word)) continue;
                
                var match = searchValue.Match(word).Groups[0];
                if (word.Replace(match.Value, replaceValue) == word) return true;
            }
            return false;
        }
    }
}
