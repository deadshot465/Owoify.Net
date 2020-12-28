using System;
using System.Collections.Generic;

namespace Owoify
{
    internal static partial class Utility
    {
        internal static List<Func<Word, Word>> SpecificWordMappingList { get; } = new List<Func<Word, Word>>()
        {
            Map_Fuc_To_Fwuc, Map_Mom_To_Mwom, Map_Time_To_Tim, Map_Me_To_Mwe,
            Map_NVowel_To_Ny, Map_Over_To_Owor, Map_Ove_To_Uv, Map_Haha_To_HehexD,
            Map_The_To_Teh, Map_You_To_U, Map_Read_To_Wead, Map_Worse_To_Wose
        };

        internal static List<Func<Word, Word>> UvuMappingList { get; } = new List<Func<Word, Word>>()
        {
            Map_O_To_OwO, Map_Ew_To_UwU, Map_Hey_To_Hay, Map_Dead_To_Ded,
            Map_N_Vowel_T_To_Nd
        };

        internal static List<Func<Word, Word>> UwuMappingList { get; } = new List<Func<Word, Word>>()
        {
            Map_Brackets_To_StarTrails, Map_PeriodCommaExclamationSemicolon_To_Kaomojis,
            Map_That_To_Dat, Map_Th_To_F, Map_Le_To_Wal, Map_Ve_To_We, Map_Ry_To_Wwy,
            Map_ROrL_To_W
        };

        internal static List<Func<Word, Word>> OwoMappingList { get; } = new List<Func<Word, Word>>()
        {
            Map_Ll_To_Ww, Map_VowelOrRExceptO_L_To_Wl, Map_Old_To_Owld,
            Map_Ol_To_Owl, Map_LOrR_O_To_Wo, Map_SpecificConsonants_O_To_Letter_And_Wo,
            Map_VOrW_Le_To_Wal, Map_Fi_To_Fwi, Map_Ver_To_Wer, Map_Poi_To_Pwoi,
            Map_SpecificConsonants_Le_To_Letter_And_Wal,
            Map_Consonant_R_To_Consonant_W,
            Map_Ly_To_Wy, Map_Ple_To_Pwe, Map_Nr_To_Nw
        };
    }
}
