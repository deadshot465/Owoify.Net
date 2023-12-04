﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Owoify
{
    public static class Owoifier
    {
        public enum OwoifyLevel
        {
            Owo,
            Uwu,
            Uvu
        }

        /// <summary>
        /// Owoify the given source string using specified owoness level.
        /// </summary>
        /// <param name="source">The source string to owoify.</param>
        /// <param name="level">The owoness level. Three levels are available (from lowest to highest): Owo, Uwu, Uvu</param>
        /// <returns>The owoified string.</returns>
        /// <exception cref="ArgumentException">When the specified owoness level is invalid.</exception>
        public static string Owoify(string source, OwoifyLevel level = OwoifyLevel.Owo)
        {
            var wordRegex = new Regex(@"[^\s]+");
            var wordMatches = wordRegex.Matches(source);

            var spaceRegex = new Regex(@"\s+");
            var spaceMatches = spaceRegex.Matches(source);

            var words = wordMatches
                .Select(match => new Word(match.Value));

            var spaces = spaceMatches
                .Select(match => new Word(match.Value));

            words = words.Select(word =>
            {
                word = Utility.SpecificWordMappingList.Aggregate(word, (current, func) => func.Invoke(current));

                switch (level)
                {
                    case OwoifyLevel.Owo:
                        word = Utility.OwoMappingList.Aggregate(word, (current, func) => func.Invoke(current));
                        break;
                    case OwoifyLevel.Uwu:
                        word = Utility.UwuMappingList.Aggregate(word, (current, func) => func.Invoke(current));
                        word = Utility.OwoMappingList.Aggregate(word, (current, func) => func.Invoke(current));
                        break;
                    case OwoifyLevel.Uvu:
                        word = Utility.UvuMappingList.Aggregate(word, (current, func) => func.Invoke(current));
                        word = Utility.UwuMappingList.Aggregate(word, (current, func) => func.Invoke(current));
                        word = Utility.OwoMappingList.Aggregate(word, (current, func) => func.Invoke(current));
                        break;
                    default:
                        throw new ArgumentException("Invalid owoness level.", nameof(level));
                }

                return word;
            });

            var result = Utility.InterleaveArrays(words, spaces);
            return string.Join(string.Empty, result);
        }

        /// <summary>
        /// Owoify the given source string using Uwu owoness level.
        /// </summary>
        /// <param name="source">The source string to owoify.</param>
        /// <returns>The owoified string.</returns>
        public static string Uwuify(string source) => Owoify(source, OwoifyLevel.Uwu);

        /// <summary>
        /// Owoify the given source string using Uvu owoness level.
        /// </summary>
        /// <param name="source">The source string to owoify.</param>
        /// <returns>The owoified string.</returns>
        public static string Uvuify(string source) => Owoify(source, OwoifyLevel.Uvu);
    }
}