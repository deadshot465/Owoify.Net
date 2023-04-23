using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Owoify
{
    public static partial class Owoifier
    {
        public enum OwoifyLevel
        {
            Owo, Uwu, Uvu
        }

#if NET7_0_OR_GREATER
        [GeneratedRegex(@"[^\s]+")]
        private static partial Regex WordRegexM();
        private static readonly Regex WordRegex = WordRegexM();
        [GeneratedRegex(@"\s+")]
        private static partial Regex SpaceRegexM();
        private static readonly Regex SpaceRegex = SpaceRegexM();
#else
        private static readonly Regex WordRegex = new Regex(@"[^\s]+");
        private static readonly Regex SpaceRegex = new Regex(@"\s+");
#endif

        /// <summary>
        /// Owoify the given source string using specified owoness level.
        /// </summary>
        /// <param name="value">The source string to owoify.</param>
        /// <param name="level">The owoness level. Three levels are available (from lowest to highest): Owo, Uwu, Uvu</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">When the specified owoness level is invalid.</exception>
        public static string Owoify(string value, OwoifyLevel level = OwoifyLevel.Owo)
        {
            var wordMatches = WordRegex.Matches(value);
            var spaceMatches = SpaceRegex.Matches(value);

            var words = wordMatches
                .Select(match => new Word(match.Value));

            var spaces = spaceMatches
                .Select(match => new Word(match.Value));

            words = words.Select(word =>
            {
                foreach (var func in Utility.SpecificWordMappingList) word = func.Invoke(word);

                switch (level)
                {
                    case OwoifyLevel.Owo:
                        foreach (var func in Utility.OwoMappingList) word = func.Invoke(word);
                        break;
                    case OwoifyLevel.Uwu:
                        foreach (var func in Utility.UwuMappingList) word = func.Invoke(word);
                        foreach (var func in Utility.OwoMappingList) word = func.Invoke(word);
                        break;
                    case OwoifyLevel.Uvu:
                        foreach (var func in Utility.UvuMappingList) word = func.Invoke(word);
                        foreach (var func in Utility.UwuMappingList) word = func.Invoke(word);
                        foreach (var func in Utility.OwoMappingList) word = func.Invoke(word);
                        break;
                    default:
                        throw new ArgumentException("Invalid owoness level.", nameof(level));
                }

                return word;
            });

            var result = Utility.InterleaveArrays(words, spaces);
            return string.Join(string.Empty, result);
        }
    }
}
