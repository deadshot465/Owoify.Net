using System;

namespace Owoify
{
    internal static partial class Utility
    {
        internal static readonly Func<Word, Word>[] SpecificWordMappingList = new Func<Word, Word>[]
            {
                MapFucToFwuc, MapMomToMwom, MapTimeToTim, MapMeToMwe,
                MapNVowelToNy, MapOverToOwor, MapOveToUv, MapHahaToHehexD,
                MapTheToTeh, MapYouToU, MapReadToWead, MapWorseToWose
            };

        internal static readonly Func<Word, Word>[] UvuMappingList = new Func<Word, Word>[]
            {
                MapOToOwO, MapEwToUwU, MapHeyToHay, MapDeadToDed,
                MapNVowelTToNd
            };

        internal static readonly Func<Word, Word>[] UwuMappingList = new Func<Word, Word>[]
            {
                MapBracketsToStarTrails, MapPeriodCommaExclamationSemicolonToKaomojis,
                MapThatToDat, MapThToF, MapLeToWal, MapVeToWe, MapRyToWwy,
                MapROrLToW
            };

        internal static readonly Func<Word, Word>[] OwoMappingList = new Func<Word, Word>[]
            {
                MapLlToWw, MapVowelOrRExceptOlToWl, MapOldToOwld,
                MapOlToOwl, MapLOrRoToWo, MapSpecificConsonantsOToLetterAndWo,
                MapVOrWLeToWal, MapFiToFwi, MapVerToWer, MapPoiToPwoi,
                MapSpecificConsonantsLeToLetterAndWal,
                MapConsonantRToConsonantW,
                MapLyToWy, MapPleToPwe, MapNrToNw
            };
    }
}
