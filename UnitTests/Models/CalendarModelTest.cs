
using Koyomi.Common;
using Koyomi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests.Models
{
    [TestClass]
    public class CalendarModelTest : TestBase
    {
        [TestMethod]
        public void 正常系_四季の値()
        {
            var calendar = new CalendarModel();
            this.LongTimeLoopAction((d) =>
            {
                calendar.Update(d);
                if (d <= new DateTime(d.Year, 2, 4).AddDays(-1))
                    Assert.AreEqual(FourSeasonKind.冬, calendar.FourSeason, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 5).AddDays(-1))
                    Assert.AreEqual(FourSeasonKind.春, calendar.FourSeason, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 7).AddDays(-1))
                    Assert.AreEqual(FourSeasonKind.夏, calendar.FourSeason, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 7).AddDays(-1))
                    Assert.AreEqual(FourSeasonKind.秋, calendar.FourSeason, d.ToString());
                else
                    Assert.AreEqual(FourSeasonKind.冬, calendar.FourSeason, d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_二十四節気の値()
        {
            var calendar = new CalendarModel();
            this.LongTimeLoopAction((d) =>
            {
                calendar.Update(d);
                if (d <= new DateTime(d.Year, 1, 5).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.冬至, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 1, 20).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.小寒, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 2, 4).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.大寒, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 2, 18).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.立春, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 5).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.雨水, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 20).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.啓蟄, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 4, 4).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.春分, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 4, 20).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.清明, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 5).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.穀雨, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 21).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.立夏, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 6, 5).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.小満, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 6, 21).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.芒種, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 7, 7).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.夏至, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 7, 23).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.小暑, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 7).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.大暑, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 23).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.立秋, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 9, 7).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.処暑, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 9, 23).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.白露, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 10, 8).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.秋分, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 10, 23).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.寒露, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 7).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.霜降, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 22).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.立冬, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 12, 7).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.小雪, calendar.SolarTerm, d.ToString());
                else if (d <= new DateTime(d.Year, 12, 22).AddDays(-1))
                    Assert.AreEqual(SolarTermKind.大雪, calendar.SolarTerm, d.ToString());
                else
                    Assert.AreEqual(SolarTermKind.冬至, calendar.SolarTerm, d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_七十二候の値()
        {
            var calendar = new CalendarModel();
            this.LongTimeLoopAction((d) =>
            {
                calendar.Update(d);
                if (d <= new DateTime(d.Year, 1, 5).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.雪下出麦, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 1, 10).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.芹乃栄, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 1, 15).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.水泉動, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 1, 20).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.雉始雊, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 1, 25).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.款冬華, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 1, 30).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.水沢腹堅, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 2, 4).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.鶏始乳, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 2, 9).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.東風解凍, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 2, 14).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.黄鶯睍睆, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 2, 19).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.魚上氷, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 2, 24).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.土脉潤起, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 1).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.霞始靆, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 6).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.草木萌動, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 11).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.蟄虫啓戸, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 16).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.桃始笑, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 21).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.菜虫化蝶, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 26).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.雀始巣, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 31).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.桜始開, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 4, 5).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.雷乃発声, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 4, 10).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.玄鳥至, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 4, 15).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.鴻雁北, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 4, 20).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.虹始見, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 4, 25).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.葭始生, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 4, 30).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.霜止出苗, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 5).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.牡丹華, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 10).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.蛙始鳴, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 15).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.蚯蚓出, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 21).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.竹笋生, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 26).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.蚕起食桑, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 31).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.紅花栄, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 6, 6).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.麦秋至, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 6, 11).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.螳螂生, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 6, 16).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.腐草為蛍, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 6, 21).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.梅子黄, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 6, 27).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.乃東枯, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 7, 2).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.菖蒲華, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 7, 7).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.半夏生, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 7, 12).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.温風至, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 7, 17).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.蓮始開, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 7, 23).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.鷹乃学習, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 7, 29).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.桐始結花, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 3).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.土潤溽暑, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 7).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.大雨時行, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 13).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.涼風至, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 18).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.寒蝉鳴, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 23).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.蒙霧升降, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 28).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.綿柎開, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 9, 2).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.天地始粛, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 9, 8).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.禾乃登, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 9, 13).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.草露白, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 9, 18).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.鶺鴒鳴, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 9, 23).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.玄鳥去, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 9, 28).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.雷乃収声, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 10, 3).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.蟄虫坏戸, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 10, 8).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.水始涸, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 10, 13).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.鴻雁来, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 10, 18).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.菊花開, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 10, 23).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.蟋蟀在戸, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 10, 28).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.霜始降, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 2).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.霎時施, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 7).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.楓蔦黄, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 12).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.山茶始開, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 17).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.地始凍, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 22).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.金盞香, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 27).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.虹蔵不見, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 12, 2).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.朔風払葉, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 12, 7).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.橘始黄, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 12, 12).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.閉塞成冬, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 12, 16).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.熊蟄穴, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 12, 22).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.鱖魚群, calendar.SolarTermMicro, d.ToString());
                else if (d <= new DateTime(d.Year, 12, 27).AddDays(-1))
                    Assert.AreEqual(SolarTermMicroKind.乃東生, calendar.SolarTermMicro, d.ToString());
                else
                    Assert.AreEqual(SolarTermMicroKind.麋角解, calendar.SolarTermMicro, d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_年の十二支の値()
        {
            var calendar = new CalendarModel();
            this.LongTimeLoopAction((d) =>
            {
                calendar.Update(d);
                if (d.Year == 1996)
                    Assert.AreEqual(JunishiKind.子, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 1997)
                    Assert.AreEqual(JunishiKind.丑, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 1998)
                    Assert.AreEqual(JunishiKind.寅, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 1999)
                    Assert.AreEqual(JunishiKind.卯, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 2000)
                    Assert.AreEqual(JunishiKind.辰, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 2001)
                    Assert.AreEqual(JunishiKind.巳, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 2002)
                    Assert.AreEqual(JunishiKind.午, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 2003)
                    Assert.AreEqual(JunishiKind.未, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 2004)
                    Assert.AreEqual(JunishiKind.申, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 2005)
                    Assert.AreEqual(JunishiKind.酉, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 2006)
                    Assert.AreEqual(JunishiKind.戌, calendar.JunishiOfYear, d.ToString());
                else if (d.Year == 2007)
                    Assert.AreEqual(JunishiKind.亥, calendar.JunishiOfYear, d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_年の十干の値()
        {
            var calendar = new CalendarModel();
            this.LongTimeLoopAction((d) =>
            {
                calendar.Update(d);
                if (d.Year == 1994)
                    Assert.AreEqual(JikkanKind.甲, calendar.JikkanOfYear, d.ToString());
                else if (d.Year == 1995)
                    Assert.AreEqual(JikkanKind.乙, calendar.JikkanOfYear, d.ToString());
                else if (d.Year == 1996)
                    Assert.AreEqual(JikkanKind.丙, calendar.JikkanOfYear, d.ToString());
                else if (d.Year == 1997)
                    Assert.AreEqual(JikkanKind.丁, calendar.JikkanOfYear, d.ToString());
                else if (d.Year == 1998)
                    Assert.AreEqual(JikkanKind.戊, calendar.JikkanOfYear, d.ToString());
                else if (d.Year == 1999)
                    Assert.AreEqual(JikkanKind.己, calendar.JikkanOfYear, d.ToString());
                else if (d.Year == 2000)
                    Assert.AreEqual(JikkanKind.庚, calendar.JikkanOfYear, d.ToString());
                else if (d.Year == 2001)
                    Assert.AreEqual(JikkanKind.辛, calendar.JikkanOfYear, d.ToString());
                else if (d.Year == 2002)
                    Assert.AreEqual(JikkanKind.壬, calendar.JikkanOfYear, d.ToString());
                else if (d.Year == 2003)
                    Assert.AreEqual(JikkanKind.癸, calendar.JikkanOfYear, d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_節月の値()
        {
            var calendar = new CalendarModel();
            this.LongTimeLoopAction((d) =>
            {
                calendar.Update(d);
                if (d <= new DateTime(d.Year, 1, 5).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.十一月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 2, 4).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.十二月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 5).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.正月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 4, 4).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.二月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 5).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.三月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 6, 5).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.四月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 7, 7).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.五月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 7).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.六月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 9, 7).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.七月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 10, 8).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.八月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 7).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.九月, calendar.Setsugetsu, d.ToString());
                else if (d <= new DateTime(d.Year, 12, 7).AddDays(-1))
                    Assert.AreEqual(SetsugetsuKind.十月, calendar.Setsugetsu, d.ToString());
                else
                    Assert.AreEqual(SetsugetsuKind.十一月, calendar.Setsugetsu, d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_六曜の値()
        {
            var calendar = new CalendarModel();
            this.LongTimeLoopAction((d) =>
            {
                calendar.Update(d);
                if (d == new DateTime(2017, 1, 1))
                    Assert.AreEqual(RokuyoKind.先負, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 2))
                    Assert.AreEqual(RokuyoKind.仏滅, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 3))
                    Assert.AreEqual(RokuyoKind.大安, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 4))
                    Assert.AreEqual(RokuyoKind.赤口, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 5))
                    Assert.AreEqual(RokuyoKind.先勝, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 6))
                    Assert.AreEqual(RokuyoKind.友引, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 7))
                    Assert.AreEqual(RokuyoKind.先負, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 8))
                    Assert.AreEqual(RokuyoKind.仏滅, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 9))
                    Assert.AreEqual(RokuyoKind.大安, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 10))
                    Assert.AreEqual(RokuyoKind.赤口, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 11))
                    Assert.AreEqual(RokuyoKind.先勝, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 12))
                    Assert.AreEqual(RokuyoKind.友引, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 13))
                    Assert.AreEqual(RokuyoKind.先負, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 14))
                    Assert.AreEqual(RokuyoKind.仏滅, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 15))
                    Assert.AreEqual(RokuyoKind.大安, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 16))
                    Assert.AreEqual(RokuyoKind.赤口, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 17))
                    Assert.AreEqual(RokuyoKind.先勝, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 18))
                    Assert.AreEqual(RokuyoKind.友引, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 19))
                    Assert.AreEqual(RokuyoKind.先負, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 20))
                    Assert.AreEqual(RokuyoKind.仏滅, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 21))
                    Assert.AreEqual(RokuyoKind.大安, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 22))
                    Assert.AreEqual(RokuyoKind.赤口, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 23))
                    Assert.AreEqual(RokuyoKind.先勝, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 24))
                    Assert.AreEqual(RokuyoKind.友引, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 25))
                    Assert.AreEqual(RokuyoKind.先負, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 26))
                    Assert.AreEqual(RokuyoKind.仏滅, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 27))
                    Assert.AreEqual(RokuyoKind.大安, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 28))
                    Assert.AreEqual(RokuyoKind.先勝, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 29))
                    Assert.AreEqual(RokuyoKind.友引, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 30))
                    Assert.AreEqual(RokuyoKind.先負, calendar.Rokuyo, d.ToString());
                else if (d == new DateTime(2017, 1, 31))
                    Assert.AreEqual(RokuyoKind.仏滅, calendar.Rokuyo, d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_十二直の値()
        {
            var calendar = new CalendarModel();
            this.LongTimeLoopAction((d) =>
            {
                calendar.Update(d);
                if (d == new DateTime(2017, 1, 1))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 2))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 3))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 4))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 5))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 6))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 7))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 8))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 9))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 10))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 11))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 12))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 13))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 14))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 15))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 16))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 17))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 18))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 19))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 20))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 21))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 22))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 23))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 24))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 25))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 26))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 27))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 28))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 29))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 30))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 1, 31))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 1))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 2))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 3))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 4))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 5))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 6))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 7))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 8))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 9))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 10))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 11))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 12))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 13))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 14))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 15))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 16))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 17))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 18))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 19))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 20))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 21))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 22))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 23))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 24))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 25))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 26))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 27))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 2, 28))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 1))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 2))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 3))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 4))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 5))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 6))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 7))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 8))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 9))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 10))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 11))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 12))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 13))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 14))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 15))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 16))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 17))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 18))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 19))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 20))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 21))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 22))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 23))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 24))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 25))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 26))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 27))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 28))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 29))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 30))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 3, 31))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 1))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 2))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 3))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 4))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 5))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 6))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 7))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 8))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 9))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 10))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 11))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 12))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 13))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 14))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 15))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 16))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 17))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 18))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 19))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 20))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 21))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 22))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 23))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 24))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 25))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 26))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 27))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 28))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 29))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 4, 30))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 1))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 2))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 3))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 4))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 5))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 6))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 7))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 8))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 9))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 10))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 11))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 12))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 13))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 14))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 15))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 16))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 17))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 18))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 19))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 20))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 21))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 22))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 23))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 24))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 25))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 26))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 27))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 28))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 29))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 30))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 5, 31))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 1))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 2))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 3))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 4))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 5))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 6))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 7))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 8))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 9))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 10))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 11))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 12))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 13))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 14))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 15))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 16))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 17))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 18))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 19))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 20))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 21))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 22))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 23))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 24))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 25))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 26))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 27))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 28))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 29))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 6, 30))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 1))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 2))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 3))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 4))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 5))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 6))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 7))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 8))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 9))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 10))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 11))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 12))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 13))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 14))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 15))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 16))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 17))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 18))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 19))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 20))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 21))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 22))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 23))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 24))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 25))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 26))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 27))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 28))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 29))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 30))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 7, 31))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 1))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 2))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 3))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 4))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 5))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 6))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 7))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 8))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 9))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 10))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 11))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 12))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 13))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 14))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 15))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 16))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 17))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 18))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 19))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 20))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 21))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 22))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 23))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 24))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 25))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 26))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 27))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 28))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 29))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 30))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 8, 31))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 1))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 2))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 3))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 4))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 5))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 6))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 7))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 8))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 9))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 10))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 11))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 12))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 13))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 14))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 15))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 16))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 17))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 18))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 19))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 20))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 21))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 22))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 23))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 24))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 25))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 26))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 27))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 28))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 29))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 9, 30))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 1))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 2))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 3))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 4))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 5))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 6))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 7))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 8))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 9))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 10))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 11))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 12))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 13))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 14))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 15))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 16))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 17))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 18))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 19))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 20))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 21))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 22))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 23))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 24))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 25))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 26))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 27))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 28))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 29))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 30))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 10, 31))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 1))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 2))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 3))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 4))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 5))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 6))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 7))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 8))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 9))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 10))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 11))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 12))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 13))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 14))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 15))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 16))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 17))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 18))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 19))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 20))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 21))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 22))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 23))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 24))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 25))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 26))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 27))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 28))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 29))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 11, 30))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 1))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 2))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 3))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 4))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 5))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 6))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 7))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 8))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 9))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 10))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 11))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 12))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 13))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 14))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 15))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 16))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 17))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 18))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 19))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 20))
                    Assert.AreEqual(JunichokuKind.執, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 21))
                    Assert.AreEqual(JunichokuKind.破, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 22))
                    Assert.AreEqual(JunichokuKind.危, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 23))
                    Assert.AreEqual(JunichokuKind.成, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 24))
                    Assert.AreEqual(JunichokuKind.納, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 25))
                    Assert.AreEqual(JunichokuKind.開, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 26))
                    Assert.AreEqual(JunichokuKind.閉, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 27))
                    Assert.AreEqual(JunichokuKind.建, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 28))
                    Assert.AreEqual(JunichokuKind.除, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 29))
                    Assert.AreEqual(JunichokuKind.満, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 30))
                    Assert.AreEqual(JunichokuKind.平, calendar.Junichoku, d.ToString());
                else if (d == new DateTime(2017, 12, 31))
                    Assert.AreEqual(JunichokuKind.定, calendar.Junichoku, d.ToString());

            });
        }

        [TestMethod]
        public void 正常系_二十八宿の値()
        {
            var calendar = new CalendarModel();
            this.LongTimeLoopAction((d) =>
            {
                calendar.Update(d);
                if (d == new DateTime(2017, 1, 1))
                    Assert.AreEqual(NijuhashukuKind.虚, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 2))
                    Assert.AreEqual(NijuhashukuKind.危, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 3))
                    Assert.AreEqual(NijuhashukuKind.室, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 4))
                    Assert.AreEqual(NijuhashukuKind.壁, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 5))
                    Assert.AreEqual(NijuhashukuKind.奎, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 6))
                    Assert.AreEqual(NijuhashukuKind.婁, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 7))
                    Assert.AreEqual(NijuhashukuKind.胃, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 8))
                    Assert.AreEqual(NijuhashukuKind.昴, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 9))
                    Assert.AreEqual(NijuhashukuKind.畢, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 10))
                    Assert.AreEqual(NijuhashukuKind.觜, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 11))
                    Assert.AreEqual(NijuhashukuKind.参, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 12))
                    Assert.AreEqual(NijuhashukuKind.井, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 13))
                    Assert.AreEqual(NijuhashukuKind.鬼, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 14))
                    Assert.AreEqual(NijuhashukuKind.柳, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 15))
                    Assert.AreEqual(NijuhashukuKind.星, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 16))
                    Assert.AreEqual(NijuhashukuKind.張, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 17))
                    Assert.AreEqual(NijuhashukuKind.翼, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 18))
                    Assert.AreEqual(NijuhashukuKind.軫, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 19))
                    Assert.AreEqual(NijuhashukuKind.角, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 20))
                    Assert.AreEqual(NijuhashukuKind.亢, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 21))
                    Assert.AreEqual(NijuhashukuKind.氐, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 22))
                    Assert.AreEqual(NijuhashukuKind.房, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 23))
                    Assert.AreEqual(NijuhashukuKind.心, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 24))
                    Assert.AreEqual(NijuhashukuKind.尾, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 25))
                    Assert.AreEqual(NijuhashukuKind.箕, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 26))
                    Assert.AreEqual(NijuhashukuKind.斗, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 27))
                    Assert.AreEqual(NijuhashukuKind.牛, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 28))
                    Assert.AreEqual(NijuhashukuKind.女, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 29))
                    Assert.AreEqual(NijuhashukuKind.虚, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 30))
                    Assert.AreEqual(NijuhashukuKind.危, calendar.Nijuhashuku, d.ToString());
                else if (d == new DateTime(2017, 1, 31))
                    Assert.AreEqual(NijuhashukuKind.室, calendar.Nijuhashuku, d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_十二星座の値()
        {
            var calendar = new CalendarModel();
            this.LongTimeLoopAction((d) =>
            {
                calendar.Update(d);
                if (d <= new DateTime(d.Year, 1, 20).AddDays(-1))
                    Assert.AreEqual(StarSignKind.山羊座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 2, 19).AddDays(-1))
                    Assert.AreEqual(StarSignKind.水瓶座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 3, 21).AddDays(-1))
                    Assert.AreEqual(StarSignKind.魚座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 4, 20).AddDays(-1))
                    Assert.AreEqual(StarSignKind.牡羊座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 5, 21).AddDays(-1))
                    Assert.AreEqual(StarSignKind.牡牛座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 6, 22).AddDays(-1))
                    Assert.AreEqual(StarSignKind.双子座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 7, 23).AddDays(-1))
                    Assert.AreEqual(StarSignKind.蟹座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 8, 23).AddDays(-1))
                    Assert.AreEqual(StarSignKind.獅子座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 9, 23).AddDays(-1))
                    Assert.AreEqual(StarSignKind.乙女座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 10, 24).AddDays(-1))
                    Assert.AreEqual(StarSignKind.天秤座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 11, 23).AddDays(-1))
                    Assert.AreEqual(StarSignKind.蠍座, calendar.StarSign, d.ToString());
                else if (d <= new DateTime(d.Year, 12, 22).AddDays(-1))
                    Assert.AreEqual(StarSignKind.射手座, calendar.StarSign, d.ToString());
                else
                    Assert.AreEqual(StarSignKind.山羊座, calendar.StarSign, d.ToString());
            });
        }
    }
}
