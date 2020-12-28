using System;
using System.Text.RegularExpressions;

namespace Owoify
{
    internal static partial class Utility
    {
        private static readonly string[] Faces = 
        {
            "(・`ω´・)", ";;w;;", "owo", "UwU", ">w<", "^w^", "(* ^ ω ^)",
            "(⌒ω⌒)", "ヽ(*・ω・)ﾉ", "(o´∀`o)", "(o･ω･o)", "＼(＾▽＾)／"
        };

        internal static Word Map_O_To_OwO(Word input)
            => input.Replace(new Regex(@"o"),
                Math.Round((decimal)new Random().NextDouble()) > 0 ? "owo" : "o");

        internal static Word Map_Ew_To_UwU(Word input)
            => input.Replace(new Regex(@"ew"), "uwu");

        internal static Word Map_Hey_To_Hay(Word input)
            => input.Replace(new Regex(@"([Hh])ey"), "$1ay");

        internal static Word Map_Dead_To_Ded(Word input)
            => input.Replace(new Regex(@"Dead"), "Ded")
                .Replace(new Regex(@"dead"), "ded");

        internal static Word Map_N_Vowel_T_To_Nd(Word input)
            => input.Replace(new Regex(@"n[aeiou]*t"), "nd");

        internal static Word Map_Read_To_Wead(Word input)
            => input.Replace(new Regex(@"Read"), "Wead")
            .Replace(new Regex(@"read"), "wead");


        internal static Word Map_Brackets_To_StarTrails(Word input)
            => input.Replace(new Regex(@"[({<]"), "｡･:*:･ﾟ★,｡･:*:･ﾟ☆")
            .Replace(new Regex(@"[)}>]"), "☆ﾟ･:*:･｡,★ﾟ･:*:･｡");

        internal static Word Map_PeriodCommaExclamationSemicolon_To_Kaomojis(Word input)
        {
            var rng = new Random();
            var index = (int)Math.Floor((decimal)(rng.NextDouble() * Faces.Length));
            input = input.Replace(new Regex(@"[.,](?![0-9])"), () => " " + Faces[index]);

            index = (int)Math.Floor((decimal)(rng.NextDouble() * Faces.Length));
            input = input.Replace(new Regex(@"[!;]+"), () => " " + Faces[index]);

            return input;
        }

        internal static Word Map_That_To_Dat(Word input)
            => input.Replace(new Regex(@"that"), "dat")
            .Replace(new Regex(@"That"), "Dat");

        internal static Word Map_Th_To_F(Word input)
            => input.Replace(new Regex(@"[Tt]h(?![Ee])"), "f")
            .Replace(new Regex(@"TH(?!E)"), "F");

        internal static Word Map_Le_To_Wal(Word input)
            => input.Replace(new Regex(@"le$"), "wal");

        internal static Word Map_Ve_To_We(Word input)
            => input.Replace(new Regex(@"ve"), "we")
            .Replace(new Regex(@"Ve"), "We");

        internal static Word Map_Ry_To_Wwy(Word input)
            => input.Replace(new Regex(@"ry"), "wwy");

        internal static Word Map_ROrL_To_W(Word input)
            => input.Replace(new Regex(@"(?:r|l)"), "w")
            .Replace(new Regex(@"(?:R|L)"), "W");


        internal static Word Map_Ll_To_Ww(Word input)
            => input.Replace(new Regex(@"ll"), "ww");

        internal static Word Map_VowelOrRExceptO_L_To_Wl(Word input)
            => input.Replace(new Regex(@"[aeiur]l$"), "wl")
            .Replace(new Regex(@"[AEIUR]([lL])$"), "W$1");

        internal static Word Map_Old_To_Owld(Word input)
            => input.Replace(new Regex(@"([Oo])ld"), "$1wld")
            .Replace(new Regex(@"OLD"), "OWLD");

        internal static Word Map_Ol_To_Owl(Word input)
            => input.Replace(new Regex(@"([Oo])l"), "$1wl")
            .Replace(new Regex(@"OL"), "OWL");

        internal static Word Map_LOrR_O_To_Wo(Word input)
            => input.Replace(new Regex(@"[lr]o"), "wo")
            .Replace(new Regex(@"[LR]([oO])"), "W$1");

        internal static Word Map_SpecificConsonants_O_To_Letter_And_Wo(Word input)
        {
            return input.Replace(new Regex(@"([bcdfghjkmnpqstxyz])o"), "$1wo")
                .Replace(new Regex(@"([BCDFGHJKMNPQSTXYZ])([oO])"),
                (m1, m2) => m1 + (m2.ToUpper() == m2 ? "W" : "w") + m2);
        }

        internal static Word Map_VOrW_Le_To_Wal(Word input)
            => input.Replace(new Regex(@"[vw]le"), "wal");

        internal static Word Map_Fi_To_Fwi(Word input)
            => input.Replace(new Regex(@"([Ff])i"), "$1wi")
            .Replace(new Regex(@"FI"), "FWI");

        internal static Word Map_Ver_To_Wer(Word input)
            => input.Replace(new Regex(@"([Vv])er"), "wer");

        internal static Word Map_Poi_To_Pwoi(Word input)
            => input.Replace(new Regex(@"([Pp])oi"), "$1woi");

        internal static Word Map_SpecificConsonants_Le_To_Letter_And_Wal(Word input)
            => input.Replace(new Regex(@"([DdFfGgHhJjPpQqRrSsTtXxYyZz])le$"), "$1wal");

        internal static Word Map_Consonant_R_To_Consonant_W(Word input)
            => input.Replace(new Regex(@"([BbCcDdFfGgKkPpQqSsTtWwXxZz])r"), "$1w");

        internal static Word Map_Ly_To_Wy(Word input)
            => input.Replace(new Regex(@"ly"), "wy")
            .Replace(new Regex(@"Ly"), "Wy");

        internal static Word Map_Ple_To_Pwe(Word input)
            => input.Replace(new Regex(@"([Pp])le"), "1we");

        internal static Word Map_Nr_To_Nw(Word input)
            => input.Replace(new Regex(@"nr"), "nw")
            .Replace(new Regex(@"NR"), "NW");

        internal static Word Map_Fuc_To_Fwuc(Word input)
            => input.Replace(new Regex(@"([Ff])uc"), "$1wuc");

        internal static Word Map_Mom_To_Mwom(Word input)
            => input.Replace(new Regex(@"([Mm])om"), "$1wom");

        internal static Word Map_Me_To_Mwe(Word input)
            => input.Replace(new Regex(@"([Mm])e"), "$1we");

        internal static Word Map_NVowel_To_Ny(Word input)
            => input.Replace(new Regex(@"n([aeiou])"), "ny$1")
            .Replace(new Regex(@"N([aeiou])"), "Ny$1")
            .Replace(new Regex(@"N([AEIOU])"), "NY$1");

        internal static Word Map_Ove_To_Uv(Word input)
            => input.Replace(new Regex(@"ove"), "uv")
            .Replace(new Regex(@"OVE"), "UV");

        internal static Word Map_Haha_To_HehexD(Word input)
            => input.Replace(new Regex(@"\b(ha|hah|heh|hehe)+\b"), "hehe xD");

        internal static Word Map_The_To_Teh(Word input)
            => input.Replace(new Regex(@"\b([Tt])he\b"), "$1eh");

        internal static Word Map_You_To_U(Word input)
            => input.Replace(new Regex(@"\bYou\b"), "U")
            .Replace(new Regex(@"\byou\b"), "u");

        internal static Word Map_Time_To_Tim(Word input)
            => input.Replace(new Regex(@"\b([Tt])ime\b"), "$1im");

        internal static Word Map_Over_To_Owor(Word input)
            => input.Replace(new Regex(@"([Oo])ver"), "$1wor");

        internal static Word Map_Worse_To_Wose(Word input)
            => input.Replace(new Regex(@"([Ww])orse"), "$1ose");
    }
}
