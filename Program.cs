using System.Linq;
using System.Text.RegularExpressions;
// ReSharper disable InconsistentNaming

namespace Owoify
{
    public static class Owoifier
    {
        public enum OwoifyLevel
        {
            Owo, Uwu, Uvu
        }

        public static string Owoify(string value, OwoifyLevel level = OwoifyLevel.Owo)
        {
            var wordRegex = new Regex(@"[^\s]+");
            var wordMatches = wordRegex.Matches(value);

            var spaceRegex = new Regex(@"\s+");
            var spaceMatches = spaceRegex.Matches(value);

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
                }

                return word;
            });

            var result = Utility.InterleaveArrays(words, spaces);
            return string.Join(string.Empty, result);
        }
    }
}
