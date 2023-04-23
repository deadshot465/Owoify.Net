using System;
using System.Text.RegularExpressions;

namespace Owoify
{
    internal static partial class Utility
    {
        private static readonly string[] Faces = {
            "(・`ω´・)", ";;w;;", "owo", "UwU", ">w<", "^w^", "(* ^ ω ^)",
            "(⌒ω⌒)", "ヽ(*・ω・)ﾉ", "(o´∀`o)", "(o･ω･o)", "＼(＾▽＾)／",
            "(*^ω^)", "(◕‿◕✿)", "(◕ᴥ◕)", "ʕ•ᴥ•ʔ", "ʕ￫ᴥ￩ʔ", "(*^.^*)",
            "(｡♥‿♥｡)", "OwO", "uwu", "uvu", "UvU", "(*￣з￣)", "(つ✧ω✧)つ",
            "(/ =ω=)/", "(╯°□°）╯︵ ┻━┻", "┬─┬ ノ( ゜-゜ノ)", "¯\\_(ツ)_/¯",
        };

#if NET7_0_OR_GREATER
        [GeneratedRegex(@"o")]
        private static partial Regex OToOwOM();
        private static readonly Regex OToOwO = OToOwOM();
        [GeneratedRegex(@"ew")]
        private static partial Regex EwToUwUM();
        private static readonly Regex EwToUwU = EwToUwUM();
        [GeneratedRegex(@"([Hh])ey")]
        private static partial Regex HeyToHayM();
        private static readonly Regex HeyToHay = HeyToHayM();
        [GeneratedRegex(@"Dead")]
        private static partial Regex DeadToDedUpperM();
        private static readonly Regex DeadToDedUpper = DeadToDedUpperM();
        [GeneratedRegex(@"dead")]
        private static partial Regex DeadToDedLowerM();
        private static readonly Regex DeadToDedLower = DeadToDedLowerM();
        [GeneratedRegex(@"n[aeiou]*t")]
        private static partial Regex NVowelTToNdM();
        private static readonly Regex NVowelTToNd = NVowelTToNdM();
        [GeneratedRegex(@"Read")]
        private static partial Regex ReadToWeadUpperM();
        private static readonly Regex ReadToWeadUpper = ReadToWeadUpperM();
        [GeneratedRegex(@"read")]
        private static partial Regex ReadToWeadLowerM();
        private static readonly Regex ReadToWeadLower = ReadToWeadLowerM();
        [GeneratedRegex(@"[({<]")]
        private static partial Regex BracketsToStarTrailsForeM();
        private static readonly Regex BracketsToStarTrailsFore = BracketsToStarTrailsForeM();
        [GeneratedRegex(@"[)}>]")]
        private static partial Regex BracketsToStarTrailsRearM();
        private static readonly Regex BracketsToStarTrailsRear = BracketsToStarTrailsRearM();
        [GeneratedRegex(@"[.,](?![0-9])")]
        private static partial Regex PeriodCommaExclamationSemicolonToKaomojisFirstM();
        private static readonly Regex PeriodCommaExclamationSemicolonToKaomojisFirst = PeriodCommaExclamationSemicolonToKaomojisFirstM();
        [GeneratedRegex(@"[!;]+")]
        private static partial Regex PeriodCommaExclamationSemicolonToKaomojisSecondM();
        private static readonly Regex PeriodCommaExclamationSemicolonToKaomojisSecond = PeriodCommaExclamationSemicolonToKaomojisSecondM();
        [GeneratedRegex(@"that")]
        private static partial Regex ThatToDatLowerM();
        private static readonly Regex ThatToDatLower = ThatToDatLowerM();
        [GeneratedRegex(@"That")]
        private static partial Regex ThatToDatUpperM();
        private static readonly Regex ThatToDatUpper = ThatToDatUpperM();
        [GeneratedRegex(@"[Tt]h(?![Ee])")]
        private static partial Regex ThToFLowerM();
        private static readonly Regex ThToFLower = ThToFLowerM();
        [GeneratedRegex(@"TH(?!E)")]
        private static partial Regex ThToFUpperM();
        private static readonly Regex ThToFUpper = ThToFUpperM();
        [GeneratedRegex(@"le$")]
        private static partial Regex LeToWalM();
        private static readonly Regex LeToWal = LeToWalM();
        [GeneratedRegex(@"ve")]
        private static partial Regex VeToWeLowerM();
        private static readonly Regex VeToWeLower = VeToWeLowerM();
        [GeneratedRegex(@"Ve")]
        private static partial Regex VeToWeUpperM();
        private static readonly Regex VeToWeUpper = VeToWeUpperM();
        [GeneratedRegex(@"ry")]
        private static partial Regex RyToWwyM();
        private static readonly Regex RyToWwy = RyToWwyM();
        [GeneratedRegex(@"(?:r|l)")]
        private static partial Regex ROrLToWLowerM();
        private static readonly Regex ROrLToWLower = ROrLToWLowerM();
        [GeneratedRegex(@"(?:R|L)")]
        private static partial Regex ROrLToWUpperM();
        private static readonly Regex ROrLToWUpper = ROrLToWUpperM();
        [GeneratedRegex(@"ll")]
        private static partial Regex LlToWwM();
        private static readonly Regex LlToWw = LlToWwM();
        [GeneratedRegex(@"[aeiur]l$")]
        private static partial Regex VowelOrRExceptOlToWlLowerM();
        private static readonly Regex VowelOrRExceptOlToWlLower = VowelOrRExceptOlToWlLowerM();
        [GeneratedRegex(@"[AEIUR]([lL])$")]
        private static partial Regex VowelOrRExceptOlToWlUpperM();
        private static readonly Regex VowelOrRExceptOlToWlUpper = VowelOrRExceptOlToWlUpperM();
        [GeneratedRegex(@"([Oo])ld")]
        private static partial Regex OldToOwldLowerM();
        private static readonly Regex OldToOwldLower = OldToOwldLowerM();
        [GeneratedRegex(@"OLD")]
        private static partial Regex OldToOwldUpperM();
        private static readonly Regex OldToOwldUpper = OldToOwldUpperM();
        [GeneratedRegex(@"([Oo])l")]
        private static partial Regex OlToOwlLowerM();
        private static readonly Regex OlToOwlLower = OlToOwlLowerM();
        [GeneratedRegex(@"OL")]
        private static partial Regex OlToOwlUpperM();
        private static readonly Regex OlToOwlUpper = OlToOwlUpperM();
        [GeneratedRegex(@"[lr]o")]
        private static partial Regex LOrRoToWoLowerM();
        private static readonly Regex LOrRoToWoLower = LOrRoToWoLowerM();
        [GeneratedRegex(@"[LR]([oO])")]
        private static partial Regex LOrRoToWoUpperM();
        private static readonly Regex LOrRoToWoUpper = LOrRoToWoUpperM();
        [GeneratedRegex(@"([bcdfghjkmnpqstxyz])o")]
        private static partial Regex SpecificConsonantsOToLetterAndWoLowerM();
        private static readonly Regex SpecificConsonantsOToLetterAndWoLower = SpecificConsonantsOToLetterAndWoLowerM();
        [GeneratedRegex(@"([BCDFGHJKMNPQSTXYZ])([oO])")]
        private static partial Regex SpecificConsonantsOToLetterAndWoUpperM();
        private static readonly Regex SpecificConsonantsOToLetterAndWoUpper = SpecificConsonantsOToLetterAndWoUpperM();
        [GeneratedRegex(@"[vw]le")]
        private static partial Regex VOrWLeToWalM();
        private static readonly Regex VOrWLeToWal = VOrWLeToWalM();
        [GeneratedRegex(@"([Ff])i")]
        private static partial Regex FiToFwiLowerM();
        private static readonly Regex FiToFwiLower = FiToFwiLowerM();
        [GeneratedRegex(@"FI")]
        private static partial Regex FiToFwiUpperM();
        private static readonly Regex FiToFwiUpper = FiToFwiUpperM();
        [GeneratedRegex(@"([Vv])er")]
        private static partial Regex VerToWerM();
        private static readonly Regex VerToWer = VerToWerM();
        [GeneratedRegex(@"([Pp])oi")]
        private static partial Regex PoiToPwoiM();
        private static readonly Regex PoiToPwoi = PoiToPwoiM();
        [GeneratedRegex(@"([DdFfGgHhJjPpQqRrSsTtXxYyZz])le$")]
        private static partial Regex SpecificConsonantsLeToLetterAndWalM();
        private static readonly Regex SpecificConsonantsLeToLetterAndWal = SpecificConsonantsLeToLetterAndWalM();
        [GeneratedRegex(@"([BbCcDdFfGgKkPpQqSsTtWwXxZz])r")]
        private static partial Regex ConsonantRToConsonantWM();
        private static readonly Regex ConsonantRToConsonantW = ConsonantRToConsonantWM();
        [GeneratedRegex(@"ly")]
        private static partial Regex LyToWyLowerM();
        private static readonly Regex LyToWyLower = LyToWyLowerM();
        [GeneratedRegex(@"Ly")]
        private static partial Regex LyToWyUpperM();
        private static readonly Regex LyToWyUpper = LyToWyUpperM();
        [GeneratedRegex(@"([Pp])le")]
        private static partial Regex PleToPweM();
        private static readonly Regex PleToPwe = PleToPweM();
        [GeneratedRegex(@"nr")]
        private static partial Regex NrToNwLowerM();
        private static readonly Regex NrToNwLower = NrToNwLowerM();
        [GeneratedRegex(@"NR")]
        private static partial Regex NrToNwUpperM();
        private static readonly Regex NrToNwUpper = NrToNwUpperM();
        [GeneratedRegex(@"([Ff])uc")]
        private static partial Regex FucToFwucM();
        private static readonly Regex FucToFwuc = FucToFwucM();
        [GeneratedRegex(@"([Mm])om")]
        private static partial Regex MomToMwomM();
        private static readonly Regex MomToMwom = MomToMwomM();
        [GeneratedRegex(@"([Mm])e")]
        private static partial Regex MeToMweM();
        private static readonly Regex MeToMwe = MeToMweM();
        [GeneratedRegex(@"n([aeiou])")]
        private static partial Regex NVowelToNyFirstM();
        private static readonly Regex NVowelToNyFirst = NVowelToNyFirstM();
        [GeneratedRegex(@"N([aeiou])")]
        private static partial Regex NVowelToNySecondM();
        private static readonly Regex NVowelToNySecond = NVowelToNySecondM();
        [GeneratedRegex(@"N([AEIOU])")]
        private static partial Regex NVowelToNyThirdM();
        private static readonly Regex NVowelToNyThird = NVowelToNyThirdM();
        [GeneratedRegex(@"ove")]
        private static partial Regex OveToUvLowerM();
        private static readonly Regex OveToUvLower = OveToUvLowerM();
        [GeneratedRegex(@"OVE")]
        private static partial Regex OveToUvUpperM();
        private static readonly Regex OveToUvUpper = OveToUvUpperM();
        [GeneratedRegex(@"\b(ha|hah|heh|hehe)+\b")]
        private static partial Regex HahaToHehexDM();
        private static readonly Regex HahaToHehexD = HahaToHehexDM();
        [GeneratedRegex(@"\b([Tt])he\b")]
        private static partial Regex TheToTehM();
        private static readonly Regex TheToTeh = TheToTehM();
        [GeneratedRegex(@"\bYou\b")]
        private static partial Regex YouToUUpperM();
        private static readonly Regex YouToUUpper = YouToUUpperM();
        [GeneratedRegex(@"\byou\b")]
        private static partial Regex YouToULowerM();
        private static readonly Regex YouToULower = YouToULowerM();
        [GeneratedRegex(@"\b([Tt])ime\b")]
        private static partial Regex TimeToTimM();
        private static readonly Regex TimeToTim = TimeToTimM();
        [GeneratedRegex(@"([Oo])ver")]
        private static partial Regex OverToOworM();
        private static readonly Regex OverToOwor = OverToOworM();
        [GeneratedRegex(@"([Ww])orse")]
        private static partial Regex WorseToWoseM();
        private static readonly Regex WorseToWose = WorseToWoseM();
#else
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
        private static readonly Regex SpecificConsonantsLeToLetterAndWal = new Regex(@"([DdFfGgHhJjPpQqRrSsTtXxYyZz])le$");
        private static readonly Regex ConsonantRToConsonantW = new Regex(@"([BbCcDdFfGgKkPpQqSsTtWwXxZz])r");
        private static readonly Regex LyToWyLower = new Regex(@"ly");
        private static readonly Regex LyToWyUpper = new Regex(@"Ly");
        private static readonly Regex PleToPwe = new Regex(@"([Pp])le");
        private static readonly Regex NrToNwLower = new Regex(@"nr");
        private static readonly Regex NrToNwUpper = new Regex(@"NR");
        private static readonly Regex FucToFwuc = new Regex(@"([Ff])uc");
        private static readonly Regex MomToMwom = new Regex(@"([Mm])om");
        private static readonly Regex MeToMwe = new Regex(@"([Mm])e");
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
#endif

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
            return input.Replace(PeriodCommaExclamationSemicolonToKaomojisFirst, () => " " + Faces[rng.Next(0, Faces.Length)])
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
            => input.Replace(NrToNwLower, "nw")
            .Replace(NrToNwUpper, "NW");


        private static Word MapFucToFwuc(Word input)
            => input.Replace(FucToFwuc, "$1wuc");

        private static Word MapMomToMwom(Word input)
            => input.Replace(MomToMwom, "$1wom");

        private static Word MapMeToMwe(Word input)
            => input.Replace(MeToMwe, "$1we");

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
    }
}
