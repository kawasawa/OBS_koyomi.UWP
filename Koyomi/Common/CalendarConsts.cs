using System;
using System.Collections.Generic;

namespace Koyomi.Common
{
    public static class BasisDate
    {
        internal const int BASIS_YEAR = 2000;

        /// <summary>
        /// 四季の期間開始日を取得します。
        /// </summary>
        public static readonly IDictionary<FourSeasonKind, DateTime> FourSeason;

        /// <summary>
        /// 二十四節気の期間開始日を取得します。
        /// </summary>
        public static readonly IDictionary<SolarTermKind, DateTime> SolarTerm;

        /// <summary>
        /// 七十二候の期間開始日を取得します。
        /// </summary>
        public static readonly IDictionary<SolarTermMicroKind, DateTime> SolarTermMicro;

        /// <summary>
        /// 十二星座の期間開始日を取得します。
        /// </summary>
        public static readonly IDictionary<StarSignKind, DateTime> StarSign;

        static BasisDate()
        {
            FourSeason = new Dictionary<FourSeasonKind, DateTime>()
            {
                { FourSeasonKind.春, new DateTime(BASIS_YEAR, 2, 4) },
                { FourSeasonKind.夏, new DateTime(BASIS_YEAR, 5, 5) },
                { FourSeasonKind.秋, new DateTime(BASIS_YEAR, 8, 7) },
                { FourSeasonKind.冬, new DateTime(BASIS_YEAR, 11, 7) },
            };
            SolarTerm = new Dictionary<SolarTermKind, DateTime>()
            {
                { SolarTermKind.小寒, new DateTime(BASIS_YEAR, 1, 5) },
                { SolarTermKind.大寒, new DateTime(BASIS_YEAR, 1, 20) },
                { SolarTermKind.立春, new DateTime(BASIS_YEAR, 2, 4) },
                { SolarTermKind.雨水, new DateTime(BASIS_YEAR, 2, 18) },
                { SolarTermKind.啓蟄, new DateTime(BASIS_YEAR, 3, 5) },
                { SolarTermKind.春分, new DateTime(BASIS_YEAR, 3, 20) },
                { SolarTermKind.清明, new DateTime(BASIS_YEAR, 4, 4) },
                { SolarTermKind.穀雨, new DateTime(BASIS_YEAR, 4, 20) },
                { SolarTermKind.立夏, new DateTime(BASIS_YEAR, 5, 5) },
                { SolarTermKind.小満, new DateTime(BASIS_YEAR, 5, 21) },
                { SolarTermKind.芒種, new DateTime(BASIS_YEAR, 6, 5) },
                { SolarTermKind.夏至, new DateTime(BASIS_YEAR, 6, 21) },
                { SolarTermKind.小暑, new DateTime(BASIS_YEAR, 7, 7) },
                { SolarTermKind.大暑, new DateTime(BASIS_YEAR, 7, 23) },
                { SolarTermKind.立秋, new DateTime(BASIS_YEAR, 8, 7) },
                { SolarTermKind.処暑, new DateTime(BASIS_YEAR, 8, 23) },
                { SolarTermKind.白露, new DateTime(BASIS_YEAR, 9, 7) },
                { SolarTermKind.秋分, new DateTime(BASIS_YEAR, 9, 23) },
                { SolarTermKind.寒露, new DateTime(BASIS_YEAR, 10, 8) },
                { SolarTermKind.霜降, new DateTime(BASIS_YEAR, 10, 23) },
                { SolarTermKind.立冬, new DateTime(BASIS_YEAR, 11, 7) },
                { SolarTermKind.小雪, new DateTime(BASIS_YEAR, 11, 22) },
                { SolarTermKind.大雪, new DateTime(BASIS_YEAR, 12, 7) },
                { SolarTermKind.冬至, new DateTime(BASIS_YEAR, 12, 22) },
            };
            SolarTermMicro = new Dictionary<SolarTermMicroKind, DateTime>()
            {
                { SolarTermMicroKind.雪下出麦, new DateTime(BASIS_YEAR, 1, 1) },
                { SolarTermMicroKind.芹乃栄, new DateTime(BASIS_YEAR, 1, 5) },
                { SolarTermMicroKind.水泉動, new DateTime(BASIS_YEAR, 1, 10) },
                { SolarTermMicroKind.雉始雊, new DateTime(BASIS_YEAR, 1, 15) },
                { SolarTermMicroKind.款冬華, new DateTime(BASIS_YEAR, 1, 20) },
                { SolarTermMicroKind.水沢腹堅, new DateTime(BASIS_YEAR, 1, 25) },
                { SolarTermMicroKind.鶏始乳, new DateTime(BASIS_YEAR, 1, 30) },
                { SolarTermMicroKind.東風解凍, new DateTime(BASIS_YEAR, 2, 4) },
                { SolarTermMicroKind.黄鶯睍睆, new DateTime(BASIS_YEAR, 2, 9) },
                { SolarTermMicroKind.魚上氷, new DateTime(BASIS_YEAR, 2, 14) },
                { SolarTermMicroKind.土脉潤起, new DateTime(BASIS_YEAR, 2, 19) },
                { SolarTermMicroKind.霞始靆, new DateTime(BASIS_YEAR, 2, 24) },
                { SolarTermMicroKind.草木萌動, new DateTime(BASIS_YEAR, 3, 1) },
                { SolarTermMicroKind.蟄虫啓戸, new DateTime(BASIS_YEAR, 3, 6) },
                { SolarTermMicroKind.桃始笑, new DateTime(BASIS_YEAR, 3, 11) },
                { SolarTermMicroKind.菜虫化蝶, new DateTime(BASIS_YEAR, 3, 16) },
                { SolarTermMicroKind.雀始巣, new DateTime(BASIS_YEAR, 3, 21) },
                { SolarTermMicroKind.桜始開, new DateTime(BASIS_YEAR, 3, 26) },
                { SolarTermMicroKind.雷乃発声, new DateTime(BASIS_YEAR, 3, 31) },
                { SolarTermMicroKind.玄鳥至, new DateTime(BASIS_YEAR, 4, 5) },
                { SolarTermMicroKind.鴻雁北, new DateTime(BASIS_YEAR, 4, 10) },
                { SolarTermMicroKind.虹始見, new DateTime(BASIS_YEAR, 4, 15) },
                { SolarTermMicroKind.葭始生, new DateTime(BASIS_YEAR, 4, 20) },
                { SolarTermMicroKind.霜止出苗, new DateTime(BASIS_YEAR, 4, 25) },
                { SolarTermMicroKind.牡丹華, new DateTime(BASIS_YEAR, 4, 30) },
                { SolarTermMicroKind.蛙始鳴, new DateTime(BASIS_YEAR, 5, 5) },
                { SolarTermMicroKind.蚯蚓出, new DateTime(BASIS_YEAR, 5, 10) },
                { SolarTermMicroKind.竹笋生, new DateTime(BASIS_YEAR, 5, 15) },
                { SolarTermMicroKind.蚕起食桑, new DateTime(BASIS_YEAR, 5, 21) },
                { SolarTermMicroKind.紅花栄, new DateTime(BASIS_YEAR, 5, 26) },
                { SolarTermMicroKind.麦秋至, new DateTime(BASIS_YEAR, 5, 31) },
                { SolarTermMicroKind.螳螂生, new DateTime(BASIS_YEAR, 6, 6) },
                { SolarTermMicroKind.腐草為蛍, new DateTime(BASIS_YEAR, 6, 11) },
                { SolarTermMicroKind.梅子黄, new DateTime(BASIS_YEAR, 6, 16) },
                { SolarTermMicroKind.乃東枯, new DateTime(BASIS_YEAR, 6, 21) },
                { SolarTermMicroKind.菖蒲華, new DateTime(BASIS_YEAR, 6, 27) },
                { SolarTermMicroKind.半夏生, new DateTime(BASIS_YEAR, 7, 2) },
                { SolarTermMicroKind.温風至, new DateTime(BASIS_YEAR, 7, 7) },
                { SolarTermMicroKind.蓮始開, new DateTime(BASIS_YEAR, 7, 12) },
                { SolarTermMicroKind.鷹乃学習, new DateTime(BASIS_YEAR, 7, 17) },
                { SolarTermMicroKind.桐始結花, new DateTime(BASIS_YEAR, 7, 23) },
                { SolarTermMicroKind.土潤溽暑, new DateTime(BASIS_YEAR, 7, 29) },
                { SolarTermMicroKind.大雨時行, new DateTime(BASIS_YEAR, 8, 3) },
                { SolarTermMicroKind.涼風至, new DateTime(BASIS_YEAR, 8, 7) },
                { SolarTermMicroKind.寒蝉鳴, new DateTime(BASIS_YEAR, 8, 13) },
                { SolarTermMicroKind.蒙霧升降, new DateTime(BASIS_YEAR, 8, 18) },
                { SolarTermMicroKind.綿柎開, new DateTime(BASIS_YEAR, 8, 23) },
                { SolarTermMicroKind.天地始粛, new DateTime(BASIS_YEAR, 8, 28) },
                { SolarTermMicroKind.禾乃登, new DateTime(BASIS_YEAR, 9, 2) },
                { SolarTermMicroKind.草露白, new DateTime(BASIS_YEAR, 9, 8) },
                { SolarTermMicroKind.鶺鴒鳴, new DateTime(BASIS_YEAR, 9, 13) },
                { SolarTermMicroKind.玄鳥去, new DateTime(BASIS_YEAR, 9, 18) },
                { SolarTermMicroKind.雷乃収声, new DateTime(BASIS_YEAR, 9, 23) },
                { SolarTermMicroKind.蟄虫坏戸, new DateTime(BASIS_YEAR, 9, 28) },
                { SolarTermMicroKind.水始涸, new DateTime(BASIS_YEAR, 10, 3) },
                { SolarTermMicroKind.鴻雁来, new DateTime(BASIS_YEAR, 10, 8) },
                { SolarTermMicroKind.菊花開, new DateTime(BASIS_YEAR, 10, 13) },
                { SolarTermMicroKind.蟋蟀在戸, new DateTime(BASIS_YEAR, 10, 18) },
                { SolarTermMicroKind.霜始降, new DateTime(BASIS_YEAR, 10, 23) },
                { SolarTermMicroKind.霎時施, new DateTime(BASIS_YEAR, 10, 28) },
                { SolarTermMicroKind.楓蔦黄, new DateTime(BASIS_YEAR, 11, 2) },
                { SolarTermMicroKind.山茶始開, new DateTime(BASIS_YEAR, 11, 7) },
                { SolarTermMicroKind.地始凍, new DateTime(BASIS_YEAR, 11, 12) },
                { SolarTermMicroKind.金盞香, new DateTime(BASIS_YEAR, 11, 17) },
                { SolarTermMicroKind.虹蔵不見, new DateTime(BASIS_YEAR, 11, 22) },
                { SolarTermMicroKind.朔風払葉, new DateTime(BASIS_YEAR, 11, 27) },
                { SolarTermMicroKind.橘始黄, new DateTime(BASIS_YEAR, 12, 2) },
                { SolarTermMicroKind.閉塞成冬, new DateTime(BASIS_YEAR, 12, 7) },
                { SolarTermMicroKind.熊蟄穴, new DateTime(BASIS_YEAR, 12, 12) },
                { SolarTermMicroKind.鱖魚群, new DateTime(BASIS_YEAR, 12, 16) },
                { SolarTermMicroKind.乃東生, new DateTime(BASIS_YEAR, 12, 22) },
                { SolarTermMicroKind.麋角解, new DateTime(BASIS_YEAR, 12, 27) },
            };
            StarSign = new Dictionary<StarSignKind, DateTime>()
            {
                { StarSignKind.水瓶座, new DateTime(BASIS_YEAR, 1, 20) },
                { StarSignKind.魚座, new DateTime(BASIS_YEAR, 2, 19) },
                { StarSignKind.牡羊座, new DateTime(BASIS_YEAR, 3, 21) },
                { StarSignKind.牡牛座, new DateTime(BASIS_YEAR, 4, 20) },
                { StarSignKind.双子座, new DateTime(BASIS_YEAR, 5, 21) },
                { StarSignKind.蟹座, new DateTime(BASIS_YEAR, 6, 22) },
                { StarSignKind.獅子座, new DateTime(BASIS_YEAR, 7, 23) },
                { StarSignKind.乙女座, new DateTime(BASIS_YEAR, 8, 23) },
                { StarSignKind.天秤座, new DateTime(BASIS_YEAR, 9, 23) },
                { StarSignKind.蠍座, new DateTime(BASIS_YEAR, 10, 24) },
                { StarSignKind.射手座, new DateTime(BASIS_YEAR, 11, 23) },
                { StarSignKind.山羊座, new DateTime(BASIS_YEAR, 12, 22) },
            };
        }
    }

    public static class Reading
    {
        public static readonly IDictionary<RokuyoKind, string> Rokuyo;
        public static readonly IDictionary<StarSignKind, string> StarSign;
        public static readonly IDictionary<FourSeasonKind, string> FourSeason;
        public static readonly IDictionary<SolarTermKind, string> SolarTerm;
        public static readonly IDictionary<JpMonthKind, string> JpMonthAlias;
        public static readonly IDictionary<JikkanKind, string> Jikkan;
        public static readonly IDictionary<JunishiKind, string> Junishi;

        static Reading()
        {
            Rokuyo = new Dictionary<RokuyoKind, string>()
            {
                { RokuyoKind.大安, "たいあん"},
                { RokuyoKind.赤口, "しゃっこう" },
                { RokuyoKind.先勝, "せんしょう" },
                { RokuyoKind.友引, "ともびき" },
                { RokuyoKind.先負, "せんぶ" },
                { RokuyoKind.仏滅, "ぶつめつ" },
            };
            StarSign = new Dictionary<StarSignKind, string>()
            {
                { StarSignKind.山羊座, "やぎ座" },
                { StarSignKind.水瓶座, "みずがめ座" },
                { StarSignKind.魚座, "うお座" },
                { StarSignKind.牡羊座, "おひつじ座" },
                { StarSignKind.牡牛座, "おうし座" },
                { StarSignKind.双子座, "ふたご座" },
                { StarSignKind.蟹座, "かに座" },
                { StarSignKind.獅子座, "しし座" },
                { StarSignKind.乙女座, "おとめ座" },
                { StarSignKind.天秤座, "てんびん座" },
                { StarSignKind.蠍座, "さそり座" },
                { StarSignKind.射手座, "いて座" },
            };
            FourSeason = new Dictionary<FourSeasonKind, string>()
            {
                { FourSeasonKind.春, "はる"},
                { FourSeasonKind.夏, "なつ"},
                { FourSeasonKind.秋, "あき"},
                { FourSeasonKind.冬, "ふゆ"},
            };
            SolarTerm = new Dictionary<SolarTermKind, string>()
            {
                { SolarTermKind.小寒, "しょうかん" },
                { SolarTermKind.大寒, "だいかん" },
                { SolarTermKind.立春, "りっしゅん" },
                { SolarTermKind.雨水, "うすい" },
                { SolarTermKind.啓蟄, "けいちつ" },
                { SolarTermKind.春分, "しゅんぶん" },
                { SolarTermKind.清明, "せいめい" },
                { SolarTermKind.穀雨, "こくう" },
                { SolarTermKind.立夏, "りっか" },
                { SolarTermKind.小満, "しょうまん" },
                { SolarTermKind.芒種, "ぼうしゅ" },
                { SolarTermKind.夏至, "げし" },
                { SolarTermKind.小暑, "しょうしょ" },
                { SolarTermKind.大暑, "たいしょ" },
                { SolarTermKind.立秋, "りっしゅう" },
                { SolarTermKind.処暑, "しょしょ" },
                { SolarTermKind.白露, "はくろ" },
                { SolarTermKind.秋分, "しゅうぶん" },
                { SolarTermKind.寒露, "かんろ" },
                { SolarTermKind.霜降, "そうこう" },
                { SolarTermKind.立冬, "りっとう" },
                { SolarTermKind.小雪, "しょうせつ" },
                { SolarTermKind.大雪, "たいせつ" },
                { SolarTermKind.冬至, "とうじ" },
            };
            JpMonthAlias = new Dictionary<JpMonthKind, string>()
            {
                { JpMonthKind.睦月, "むつき" },
                { JpMonthKind.如月, "きさらぎ" },
                { JpMonthKind.弥生, "やよい" },
                { JpMonthKind.卯月, "うづき" },
                { JpMonthKind.皐月, "さつき" },
                { JpMonthKind.水無月, "みなづき" },
                { JpMonthKind.文月, "ふみづき" },
                { JpMonthKind.葉月, "はづき" },
                { JpMonthKind.長月, "ながつき" },
                { JpMonthKind.神無月, "かんなづき" },
                { JpMonthKind.霜月, "しもつき" },
                { JpMonthKind.師走, "しわす" },
            };
            Jikkan = new Dictionary<JikkanKind, string>()
            {
                { JikkanKind.甲, "きのえ" },
                { JikkanKind.乙, "きのと" },
                { JikkanKind.丙, "ひのえ" },
                { JikkanKind.丁, "ひのと" },
                { JikkanKind.戊, "つちのえ" },
                { JikkanKind.己, "つちのと" },
                { JikkanKind.庚, "かのえ" },
                { JikkanKind.辛, "かのと" },
                { JikkanKind.壬, "みずのえ" },
                { JikkanKind.癸, "みずのと" },
            };
            Junishi = new Dictionary<JunishiKind, string>()
            {
                { JunishiKind.子, "ね" },
                { JunishiKind.丑, "うし" },
                { JunishiKind.寅, "とら" },
                { JunishiKind.卯, "う" },
                { JunishiKind.辰, "たつ" },
                { JunishiKind.巳, "み" },
                { JunishiKind.午, "うま" },
                { JunishiKind.未, "ひつじ" },
                { JunishiKind.申, "さる" },
                { JunishiKind.酉, "とり" },
                { JunishiKind.戌, "いぬ" },
                { JunishiKind.亥, "い" },
            };
        }
    }
}
