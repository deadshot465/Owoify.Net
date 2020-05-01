using System.Linq;
using System.Text.RegularExpressions;

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
                foreach (var func in Utility.SpecificWordMappingList)
                {
                    word = func.Invoke(word);
                }

                switch (level)
                {
                    case OwoifyLevel.Owo:
                        foreach (var func in Utility.OwoMappingList)
                            word = func.Invoke(word);
                        break;
                    case OwoifyLevel.Uwu:
                        foreach (var func in Utility.UwuMappingList)
                            word = func.Invoke(word);
                        foreach (var func in Utility.OwoMappingList)
                            word = func.Invoke(word);
                        break;
                    case OwoifyLevel.Uvu:
                        foreach (var func in Utility.UvuMappingList)
                            word = func.Invoke(word);
                        foreach (var func in Utility.UwuMappingList)
                            word = func.Invoke(word);
                        foreach (var func in Utility.OwoMappingList)
                            word = func.Invoke(word);
                        break;
                    default:
                        break;
                }

                return word;
            });

            var result = Utility.InterleaveArrays(words.ToList(), spaces.ToList());
            return string.Join(string.Empty, result);
        }
    }
}
