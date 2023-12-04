﻿using System;
using System.Collections.Generic;

namespace Owoify
{
    internal static partial class Utility
    {
        internal static IEnumerable<Func<Word, Word>> SpecificWordMappingList => new List<Func<Word, Word>>
            {
                MapFucToFwuc, MapMomToMwom, MapTimeToTim, MapMeToMwe,
                MapOverToOwor, MapOveToUv, MapHahaToHehexD,
                MapTheToTeh, MapYouToU, MapReadToWead, MapWorseToWose,
                MapGreatToGwate, MapAviatToAwiat, MapDedicatToDeditat,
                MapRememberToRember, MapWhenToWen, MapFrightenedToFrigten,
                MapMemeToMem, MapFeelToFell
            };

        internal static IEnumerable<Func<Word, Word>> UvuMappingList => new List<Func<Word, Word>>
            {
                MapOToOwO, MapEwToUwU, MapHeyToHay, MapDeadToDed,
                MapNVowelTToNd
            };

        internal static IEnumerable<Func<Word, Word>> UwuMappingList => new List<Func<Word, Word>>
            {
                MapBracketsToStarTrails, MapPeriodCommaExclamationSemicolonToKaomojis,
                MapThatToDat, MapThToF, MapLeToWal, MapVeToWe, MapRyToWwy,
                MapROrLToW
            };

        internal static IEnumerable<Func<Word, Word>> OwoMappingList => new List<Func<Word, Word>>
            {
                MapNVowelToNy, MapLlToWw, MapVowelOrRExceptOlToWl, MapOldToOwld,
                MapOlToOwl, MapLOrRoToWo, MapSpecificConsonantsOToLetterAndWo,
                MapVOrWLeToWal, MapFiToFwi, MapVerToWer, MapPoiToPwoi,
                MapSpecificConsonantsLeToLetterAndWal,
                MapConsonantRToConsonantW,
                MapLyToWy, MapPleToPwe, MapNrToNw,
                MapMemToMwem, UnmapNywoToNyo
            };
    }
}
