using System;
using System.Text.RegularExpressions;

namespace Owoify
{
    internal static partial class Utility
    {
        private static readonly string[] Faces =
        {
            "(・`ω´・)", ";;w;;", "owo", "UwU", ">w<", "^w^", "(* ^ ω ^)",
            "(⌒ω⌒)", "ヽ(*・ω・)ﾉ", "(o´∀`o)", "(o･ω･o)", "＼(＾▽＾)／",
            "(*^ω^)", "(◕‿◕✿)", "(◕ᴥ◕)", "ʕ•ᴥ•ʔ", "ʕ￫ᴥ￩ʔ", "(*^.^*)",
            "(｡♥‿♥｡)", "OwO", "uwu", "uvu", "UvU", "(*￣з￣)", "(つ✧ω✧)つ",
            "(/ =ω=)/", "(╯°□°）╯︵ ┻━┻", "┬─┬ ノ( ゜-゜ノ)", "¯\\_(ツ)_/¯",
        };

        private static readonly Regex OToOwO = new Regex(@"o");
        private static readonly Regex EwToUwU = new Regex(@"ew");
        private static readonly Regex HeyToHay = new Regex(@"([Hh])ey");
        private static readonly Regex DeadToDedUpper = new Regex(@"Dead");
        private static readonly Regex DeadToDedLower = new Regex(@"dead");
        private static readonly Regex NVowelTToNd = new Regex(@"n[aeiou]*t");
        private static readonly Regex ReadToWeadUpper = new Regex(@"Read");
        private static readonly Regex ReadToWeadLower = new Regex(@"read");
        private static readonly Regex BracketsToStarTrailsFore = new Regex(@"[({<]");
        private static readonly Regex BracketsToStarTrailsRear = new Regex(@"[)}>]");
        private static readonly Regex PeriodCommaExclamationSemicolonToKaomojisFirst = new Regex(@"[.,](?![0-9])");
        private static readonly Regex PeriodCommaExclamationSemicolonToKaomojisSecond = new Regex(@"[!;]+");
        private static readonly Regex ThatToDatLower = new Regex(@"that");
        private static readonly Regex ThatToDatUpper = new Regex(@"That");
        private static readonly Regex ThToFLower = new Regex(@"[Tt]h(?![Ee])");
        private static readonly Regex ThToFUpper = new Regex(@"TH(?!E)");
        private static readonly Regex LeToWal = new Regex(@"le$");
        private static readonly Regex VeToWeLower = new Regex(@"ve");
        private static readonly Regex VeToWeUpper = new Regex(@"Ve");
        private static readonly Regex RyToWwy = new Regex(@"ry");
        private static readonly Regex ROrLToWLower = new Regex(@"(?:r|l)");
        private static readonly Regex ROrLToWUpper = new Regex(@"(?:R|L)");
        private static readonly Regex LlToWw = new Regex(@"ll");
        private static readonly Regex VowelOrRExceptOlToWlLower = new Regex(@"[aeiur]l$");
        private static readonly Regex VowelOrRExceptOlToWlUpper = new Regex(@"[AEIUR]([lL])$");
        private static readonly Regex OldToOwldLower = new Regex(@"([Oo])ld");
        private static readonly Regex OldToOwldUpper = new Regex(@"OLD");
        private static readonly Regex OlToOwlLower = new Regex(@"([Oo])l");
        private static readonly Regex OlToOwlUpper = new Regex(@"OL");
        private static readonly Regex LOrRoToWoLower = new Regex(@"[lr]o");
        private static readonly Regex LOrRoToWoUpper = new Regex(@"[LR]([oO])");
        private static readonly Regex SpecificConsonantsOToLetterAndWoLower = new Regex(@"([bcdfghjkmnpqstxyz])o");
        private static readonly Regex SpecificConsonantsOToLetterAndWoUpper = new Regex(@"([BCDFGHJKMNPQSTXYZ])([oO])");
        private static readonly Regex VOrWLeToWal = new Regex(@"[vw]le");
        private static readonly Regex FiToFwiLower = new Regex(@"([Ff])i");
        private static readonly Regex FiToFwiUpper = new Regex(@"FI");
        private static readonly Regex VerToWer = new Regex(@"([Vv])er");
        private static readonly Regex PoiToPwoi = new Regex(@"([Pp])oi");

        private static readonly Regex SpecificConsonantsLeToLetterAndWal =
            new Regex(@"([DdFfGgHhJjPpQqRrSsTtXxYyZz])le$");

        private static readonly Regex ConsonantRToConsonantW = new Regex(@"([BbCcDdFfGgKkPpQqSsTtWwXxZz])r");
        private static readonly Regex LyToWyLower = new Regex(@"ly");
        private static readonly Regex LyToWyUpper = new Regex(@"Ly");
        private static readonly Regex PleToPwe = new Regex(@"([Pp])le");
        private static readonly Regex NrToNwLower = new Regex(@"([Nn])r");
        private static readonly Regex NrToNwUpper = new Regex(@"NR");
        private static readonly Regex MemToMwemUpper = new Regex(@"Mem");
        private static readonly Regex MemToMwemLower = new Regex(@"mem");
        private static readonly Regex NywoToNyo = new Regex(@"([Nn])ywo");
        private static readonly Regex FucToFwuc = new Regex(@"([Ff])uc");
        private static readonly Regex MomToMwom = new Regex(@"([Mm])om");
        private static readonly Regex MeToMweUpper = new Regex(@"^Me$");
        private static readonly Regex MeToMweLower = new Regex(@"^me$");
        private static readonly Regex NVowelToNyFirst = new Regex(@"n([aeiou])");
        private static readonly Regex NVowelToNySecond = new Regex(@"N([aeiou])");
        private static readonly Regex NVowelToNyThird = new Regex(@"N([AEIOU])");
        private static readonly Regex OveToUvLower = new Regex(@"ove");
        private static readonly Regex OveToUvUpper = new Regex(@"OVE");
        private static readonly Regex HahaToHehexD = new Regex(@"\b(ha|hah|heh|hehe)+\b");
        private static readonly Regex TheToTeh = new Regex(@"\b([Tt])he\b");
        private static readonly Regex YouToUUpper = new Regex(@"\bYou\b");
        private static readonly Regex YouToULower = new Regex(@"\byou\b");
        private static readonly Regex TimeToTim = new Regex(@"\b([Tt])ime\b");
        private static readonly Regex OverToOwor = new Regex(@"([Oo])ver");
        private static readonly Regex WorseToWose = new Regex(@"([Ww])orse");
        private static readonly Regex GreatToGwate = new Regex(@"([Gg])reat");
        private static readonly Regex AviatToAwiat = new Regex(@"([Aa])viat");
        private static readonly Regex DedicatToDeditat = new Regex(@"([Dd])edicat");
        private static readonly Regex RememberToRember = new Regex(@"([Rr])emember");
        private static readonly Regex WhenToWen = new Regex(@"([Ww])hen");
        private static readonly Regex FrightenedToFrigten = new Regex(@"([Ff])righten(ed)*");
        private static readonly Regex MemeToMemFirst = new Regex(@"Meme");
        private static readonly Regex MemeToMemSecond = new Regex(@"Mem");
        private static readonly Regex FeelToFell = new Regex(@"^([Ff])eel$");

        private static Word MapOToOwO(Word input)
            => input.Replace(OToOwO,
                new Random().Next(0, 2) > 0 ? "owo" : "o");

        private static Word MapEwToUwU(Word input)
            => input.Replace(EwToUwU, "uwu");

        private static Word MapHeyToHay(Word input)
            => input.Replace(HeyToHay, "$1ay");

        private static Word MapDeadToDed(Word input)
            => input.Replace(DeadToDedUpper, "Ded")
                .Replace(DeadToDedLower, "ded");

        private static Word MapNVowelTToNd(Word input)
            => input.Replace(NVowelTToNd, "nd");

        private static Word MapReadToWead(Word input)
            => input.Replace(ReadToWeadUpper, "Wead")
                .Replace(ReadToWeadLower, "wead");


        private static Word MapBracketsToStarTrails(Word input)
            => input.Replace(BracketsToStarTrailsFore, "｡･:*:･ﾟ★,｡･:*:･ﾟ☆")
                .Replace(BracketsToStarTrailsRear, "☆ﾟ･:*:･｡,★ﾟ･:*:･｡");

        private static Word MapPeriodCommaExclamationSemicolonToKaomojis(Word input)
        {
            var rng = new Random();
            return input.Replace(PeriodCommaExclamationSemicolonToKaomojisFirst,
                    () => " " + Faces[rng.Next(0, Faces.Length)])
                .Replace(PeriodCommaExclamationSemicolonToKaomojisSecond, () => " " + Faces[rng.Next(0, Faces.Length)]);
        }

        private static Word MapThatToDat(Word input)
            => input.Replace(ThatToDatLower, "dat")
                .Replace(ThatToDatUpper, "Dat");

        private static Word MapThToF(Word input)
            => input.Replace(ThToFLower, "f")
                .Replace(ThToFUpper, "F");

        private static Word MapLeToWal(Word input)
            => input.Replace(LeToWal, "wal");

        private static Word MapVeToWe(Word input)
            => input.Replace(VeToWeLower, "we")
                .Replace(VeToWeUpper, "We");

        private static Word MapRyToWwy(Word input)
            => input.Replace(RyToWwy, "wwy");

        private static Word MapROrLToW(Word input)
            => input.Replace(ROrLToWLower, "w")
                .Replace(ROrLToWUpper, "W");


        private static Word MapLlToWw(Word input)
            => input.Replace(LlToWw, "ww");

        private static Word MapVowelOrRExceptOlToWl(Word input)
            => input.Replace(VowelOrRExceptOlToWlLower, "wl")
                .Replace(VowelOrRExceptOlToWlUpper, "W$1");

        private static Word MapOldToOwld(Word input)
            => input.Replace(OldToOwldLower, "$1wld")
                .Replace(OldToOwldUpper, "OWLD");

        private static Word MapOlToOwl(Word input)
            => input.Replace(OlToOwlLower, "$1wl")
                .Replace(OlToOwlUpper, "OWL");

        private static Word MapLOrRoToWo(Word input)
            => input.Replace(LOrRoToWoLower, "wo")
                .Replace(LOrRoToWoUpper, "W$1");

        private static Word MapSpecificConsonantsOToLetterAndWo(Word input)
        {
            return input.Replace(SpecificConsonantsOToLetterAndWoLower, "$1wo")
                .Replace(SpecificConsonantsOToLetterAndWoUpper,
                    (m1, m2) =>
                        m1 + (m2.ToUpper() == m2 ? "W" : "w") + m2);
        }

        private static Word MapVOrWLeToWal(Word input)
            => input.Replace(VOrWLeToWal, "wal");

        private static Word MapFiToFwi(Word input)
            => input.Replace(FiToFwiLower, "$1wi")
                .Replace(FiToFwiUpper, "FWI");

        private static Word MapVerToWer(Word input)
            => input.Replace(VerToWer, "wer");

        private static Word MapPoiToPwoi(Word input)
            => input.Replace(PoiToPwoi, "$1woi");

        private static Word MapSpecificConsonantsLeToLetterAndWal(Word input)
            => input.Replace(SpecificConsonantsLeToLetterAndWal, "$1wal");

        private static Word MapConsonantRToConsonantW(Word input)
            => input.Replace(ConsonantRToConsonantW, "$1w");

        private static Word MapLyToWy(Word input)
            => input.Replace(LyToWyLower, "wy")
                .Replace(LyToWyUpper, "Wy");

        private static Word MapPleToPwe(Word input)
            => input.Replace(PleToPwe, "1we");

        private static Word MapNrToNw(Word input)
            => input.Replace(NrToNwLower, "$1w")
                .Replace(NrToNwUpper, "NW");

        private static Word MapMemToMwem(Word input)
            => input.Replace(MemToMwemUpper, "mwem")
                .Replace(MemToMwemLower, "Mwem");

        private static Word UnmapNywoToNyo(Word input) => input.Replace(NywoToNyo, "$1yo");

        private static Word MapFucToFwuc(Word input)
            => input.Replace(FucToFwuc, "$1wuc");

        private static Word MapMomToMwom(Word input)
            => input.Replace(MomToMwom, "$1wom");

        private static Word MapMeToMwe(Word input)
            => input.Replace(MeToMweUpper, "Mwe")
                .Replace(MeToMweLower, "mwe");

        private static Word MapNVowelToNy(Word input)
            => input.Replace(NVowelToNyFirst, "ny$1")
                .Replace(NVowelToNySecond, "Ny$1")
                .Replace(NVowelToNyThird, "NY$1");

        private static Word MapOveToUv(Word input)
            => input.Replace(OveToUvLower, "uv")
                .Replace(OveToUvUpper, "UV");

        private static Word MapHahaToHehexD(Word input)
            => input.Replace(HahaToHehexD, "hehe xD");

        private static Word MapTheToTeh(Word input)
            => input.Replace(TheToTeh, "$1eh");

        private static Word MapYouToU(Word input)
            => input.Replace(YouToUUpper, "U")
                .Replace(YouToULower, "u");

        private static Word MapTimeToTim(Word input)
            => input.Replace(TimeToTim, "$1im");

        private static Word MapOverToOwor(Word input)
            => input.Replace(OverToOwor, "$1wor");

        private static Word MapWorseToWose(Word input)
            => input.Replace(WorseToWose, "$1ose");

        private static Word MapGreatToGwate(Word input) => input.Replace(GreatToGwate, "$1wate");

        private static Word MapAviatToAwiat(Word input) => input.Replace(AviatToAwiat, "$1wiat");

        private static Word MapDedicatToDeditat(Word input) => input.Replace(DedicatToDeditat, "$1editat");

        private static Word MapRememberToRember(Word input) => input.Replace(RememberToRember, "$1ember");

        private static Word MapWhenToWen(Word input) => input.Replace(WhenToWen, "$1en");

        private static Word MapFrightenedToFrigten(Word input) => input.Replace(FrightenedToFrigten, "$1rigten");

        private static Word MapMemeToMem(Word input) =>
            input.Replace(MemeToMemFirst, "mem")
                .Replace(MemeToMemSecond, "Mem");

        private static Word MapFeelToFell(Word input) => input.Replace(FeelToFell, "$1ell");
    }
}