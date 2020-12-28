using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Owoify.Models;
using static Owoify.Utility;

namespace Owoify
{
    public static class Owoifier
    {
        private static readonly Dictionary<OwoifyLevel, List<Func<Word, Word>>[]> Owoifiers = new Dictionary<OwoifyLevel, List<Func<Word, Word>>[]>()
        {
            { OwoifyLevel.Owo, new[] { OwoMappingList } },
            { OwoifyLevel.Uwu, new[] { UwuMappingList, OwoMappingList } },
            { OwoifyLevel.Uvu, new[] { UvuMappingList, UwuMappingList, OwoMappingList } }
        };
        
        public static string Owoify(string value, OwoifyLevel owoifyLevel = OwoifyLevel.Owo)
        {
            var words = GetMatchesAsWords(value, @"[^\s]+");
            var spaces = GetMatchesAsWords(value, @"\s+");

            words = words.Select(word => Mutate(owoifyLevel, word));

            var result = words.Zip(spaces, (word, space) => new[] {word, space}).SelectMany(c => c);
            return string.Join(string.Empty, result);
        }
        
        private static IEnumerable<Word> GetMatchesAsWords(string value, string pattern)
        {
            var regex = new Regex(pattern);
            return regex.Matches(value).Select(match => new Word(match.Value));
        }

        private static Word Mutate(OwoifyLevel level, Word word)
        {
            word = SpecificWordMappingList.Aggregate(word, (current, func) => func.Invoke(current));
            return InnerMutate(word, Owoifiers[level]);
        }

        private static Word InnerMutate(Word word, IEnumerable<List<Func<Word, Word>>> owoifiers)
        {
            return owoifiers.Aggregate(word, (innerWord, owoifier) => 
                owoifier.Aggregate(innerWord, (current, innerOwoifier) => 
                    innerOwoifier.Invoke(current)));
        }
    }
}
