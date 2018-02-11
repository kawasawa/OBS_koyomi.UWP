using Koyomi.Common;
using Prism.Mvvm;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Koyomi.Models
{
    public class CalendarModel : BindableBase
    {
        /// <summary>
        /// 24時間に相当するナノ秒値を定義します。
        /// </summary>
        private const long TICKS_PER_DAY = 10000L * 1000 * 60 * 60 * 24;

        /// <summary>
        /// 西暦 0001/01/01 00:00:00 における 西暦 -4712/01/01 12:00:00 からの日数を定義します。
        /// </summary>
        private const double JULIAN_DAY_FOR_AD_ZERO_YEAR = 1721425.5;

        /// <summary>
        /// 修正ユリウス通日を導出するためのユリウス通日から減算される補正値を定義します。
        /// </summary>
        private const double MODIFIED_VALUE = 2400000.5;

        private static readonly CultureInfo _cultureInfo = new CultureInfo("ja-JP");
        private static readonly JapaneseCalendar _calendar = new JapaneseCalendar();
        private static readonly JapaneseLunisolarCalendar _lunisolarCalendar = new JapaneseLunisolarCalendar();

        protected DateTime Source { get; set; }

        private int _oldYear;
        private int _oldMonth;
        private int _oldDay;
        private int _leapMonth;

        public int Year => this.Source.Year;
        public int Month => this.Source.Month;
        public int Day => this.Source.Day;
        public int DayOfYear => this.Source.DayOfYear;

        public int OldYear
        {
            get => this._oldYear;
            private set => this.SetProperty(ref this._oldYear, value);
        }

        public int OldMonth
        {
            get => this._oldMonth;
            private set => this.SetProperty(ref this._oldMonth, value);
        }

        public int OldDay
        {
            get => this._oldDay;
            private set => this.SetProperty(ref this._oldDay, value);
        }

        public int LeapMonth
        {
            get => this._leapMonth;
            private set => this.SetProperty(ref this._leapMonth, value);
        }

        public int SetsuYear
        {
            get
            {
                return this.GetSetsuGiriDate().year;
            }
        }

        public int SetsuMonth
        {
            get
            {
                return this.GetSetsuGiriDate().month;
            }
        }

        public int SetsuDay
        {
            get
            {
                return this.GetSetsuGiriDate().day;
            }
        }

        public string EraName
        {
            get
            {
                try
                {
                    return this.Source.ToString("gg", _cultureInfo);
                }
                catch
                {
                    return string.Empty;
                }
            }
        }

        public int EraYear
        {
            get
            {
                try
                {
                    return int.Parse(this.Source.ToString("yy", _cultureInfo));
                }
                catch
                {
                    return 0;
                }
            }
        }

        public double JulianDay
        {
            get
            {
                // ユリウス日の開始点からのナノ秒を積算し、一日当たりのナノ秒で割り日数に戻す
                return ((JULIAN_DAY_FOR_AD_ZERO_YEAR * TICKS_PER_DAY) + this.Source.Ticks) / TICKS_PER_DAY;
            }
        }

        public double ModifiedJulianDay
        {
            get
            {
                return this.JulianDay - MODIFIED_VALUE;
            }
        }

        public int MoonAge
        {
            get
            {
                // 簡易月齢計算法
                //   a = (((y - 11) % 19) * 11 + c(m) + d) % 30
                //     a   : 月齢
                //     y   : 年数
                //     m   : 月数
                //     d   : 日数
                //     c(m): 月数に対応する定数

                int c(int m)
                {
                    switch (m)
                    {
                        case 1:
                            return 0;
                        case 2:
                            return 2;
                        case 3:
                            return 0;
                        case 4:
                            return 2;
                        case 5:
                            return 2;
                        case 6:
                            return 4;
                        case 7:
                            return 5;
                        case 8:
                            return 6;
                        case 9:
                            return 7;
                        case 10:
                            return 8;
                        case 11:
                            return 9;
                        case 12:
                            return 10;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(m));
                    }
                }
                return ((this.Year - 11) % 19 * 11 + c(this.Month) + this.Day) % 30;
            }
        }

        public JpMonthKind JpMonth
        {
            get
            {
                return (JpMonthKind)(this.Month - 1);
            }
        }

        public JpDayOfWeekKind JpDayOfWeek
        {
            get
            {
                switch (this.Source.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        return JpDayOfWeekKind.日;
                    case DayOfWeek.Monday:
                        return JpDayOfWeekKind.月;
                    case DayOfWeek.Tuesday:
                        return JpDayOfWeekKind.火;
                    case DayOfWeek.Wednesday:
                        return JpDayOfWeekKind.水;
                    case DayOfWeek.Thursday:
                        return JpDayOfWeekKind.木;
                    case DayOfWeek.Friday:
                        return JpDayOfWeekKind.金;
                    case DayOfWeek.Saturday:
                        return JpDayOfWeekKind.土;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public FourSeasonKind FourSeason
        {
            get
            {
                switch (this.SolarTerm)
                {
                    case SolarTermKind.立春:
                    case SolarTermKind.雨水:
                    case SolarTermKind.啓蟄:
                    case SolarTermKind.春分:
                    case SolarTermKind.清明:
                    case SolarTermKind.穀雨:
                        return FourSeasonKind.春;
                    case SolarTermKind.立夏:
                    case SolarTermKind.小満:
                    case SolarTermKind.芒種:
                    case SolarTermKind.夏至:
                    case SolarTermKind.小暑:
                    case SolarTermKind.大暑:
                        return FourSeasonKind.夏;
                    case SolarTermKind.立秋:
                    case SolarTermKind.処暑:
                    case SolarTermKind.白露:
                    case SolarTermKind.秋分:
                    case SolarTermKind.寒露:
                    case SolarTermKind.霜降:
                        return FourSeasonKind.秋;
                    case SolarTermKind.立冬:
                    case SolarTermKind.小雪:
                    case SolarTermKind.大雪:
                    case SolarTermKind.冬至:
                    case SolarTermKind.小寒:
                    case SolarTermKind.大寒:
                        return FourSeasonKind.冬;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public SolarTermKind SolarTerm
        {
            get
            {
                return CalendarService.GetKind(
                    this.Source,
                    CalendarService.AdjustDate(this.Source, BasisDate.SolarTerm));
            }
        }

        public SolarTermMicroKind SolarTermMicro
        {
            get
            {
                return CalendarService.GetKind(
                    this.Source,
                    CalendarService.AdjustDate(this.Source, BasisDate.SolarTermMicro));
            }
        }

        public JikkanKind JikkanOfYear
        {
            get
            {
                return (JikkanKind)((this.Year + 6) % Enum.GetValues(typeof(JikkanKind)).Length);
            }
        }

        public JunishiKind JunishiOfYear
        {
            get
            {
                return (JunishiKind)((this.Year + 8) % Enum.GetValues(typeof(JunishiKind)).Length);
            }
        }

        public JikkanKind JikkanOfMonth
        {
            get
            {
                // 暦月 | １ | ２ | ３ | ４ | ５ | ６ | ７ | ８ | ９ | 10 | 11 | 12 | [%5]
                // 天干 | 戊 | 己 | 庚 | 辛 | 壬 | 癸 | 甲 | 乙 | 丙 | 丁 | 戊 | 己 | 0
                // 　　 | 庚 | 辛 | 壬 | 癸 | 甲 | 乙 | 丙 | 丁 | 戊 | 己 | 庚 | 辛 | 1
                // 　　 | 壬 | 癸 | 甲 | 乙 | 丙 | 丁 | 戊 | 己 | 庚 | 辛 | 壬 | 癸 | 2
                // 　　 | 甲 | 乙 | 丙 | 丁 | 戊 | 己 | 庚 | 辛 | 壬 | 癸 | 甲 | 乙 | 3
                // 　　 | 丙 | 丁 | 戊 | 己 | 庚 | 辛 | 壬 | 癸 | 甲 | 乙 | 丙 | 丁 | 4

                int gap;
                switch (this.Year % 5)
                {
                    case 0:
                        gap = 4;
                        break;
                    case 1:
                        gap = 6;
                        break;
                    case 2:
                        gap = 8;
                        break;
                    case 3:
                        gap = 0;
                        break;
                    case 4:
                        gap = 2;
                        break;
                    default:
                        throw new Exception();
                }
                return (JikkanKind)((this.Month + gap - 1) % Enum.GetValues(typeof(JikkanKind)).Length);
            }
        }

        public JunishiKind JunishiOfMonth
        {
            get
            {
                // 暦月 | １ | ２ | ３ | ４ | ５ | ６ | ７ | ８ | ９ | 10 | 11 | 12 |
                // 地支 | 寅 | 卯 | 辰 | 巳 | 午 | 未 | 申 | 酉 | 戌 | 亥 | 子 | 丑 |
                return (JunishiKind)((this.Month + 1) % Enum.GetValues(typeof(JunishiKind)).Length);
            }
        }

        public JikkanKind JikkanOfDay
        {
            get
            {
                return (JikkanKind)((this.ModifiedJulianDay) % Enum.GetValues(typeof(JikkanKind)).Length);
            }
        }

        public JunishiKind JunishiOfDay
        {
            get
            {
                return (JunishiKind)((this.ModifiedJulianDay + 2) % Enum.GetValues(typeof(JunishiKind)).Length);
            }
        }

        public SetsugetsuKind Setsugetsu
        {
            get
            {
                switch (this.SolarTerm)
                {
                    case SolarTermKind.立春:
                    case SolarTermKind.雨水:
                        return SetsugetsuKind.正月;
                    case SolarTermKind.啓蟄:
                    case SolarTermKind.春分:
                        return SetsugetsuKind.二月;
                    case SolarTermKind.清明:
                    case SolarTermKind.穀雨:
                        return SetsugetsuKind.三月;
                    case SolarTermKind.立夏:
                    case SolarTermKind.小満:
                        return SetsugetsuKind.四月;
                    case SolarTermKind.芒種:
                    case SolarTermKind.夏至:
                        return SetsugetsuKind.五月;
                    case SolarTermKind.小暑:
                    case SolarTermKind.大暑:
                        return SetsugetsuKind.六月;
                    case SolarTermKind.立秋:
                    case SolarTermKind.処暑:
                        return SetsugetsuKind.七月;
                    case SolarTermKind.白露:
                    case SolarTermKind.秋分:
                        return SetsugetsuKind.八月;
                    case SolarTermKind.寒露:
                    case SolarTermKind.霜降:
                        return SetsugetsuKind.九月;
                    case SolarTermKind.立冬:
                    case SolarTermKind.小雪:
                        return SetsugetsuKind.十月;
                    case SolarTermKind.大雪:
                    case SolarTermKind.冬至:
                        return SetsugetsuKind.十一月;
                    case SolarTermKind.小寒:
                    case SolarTermKind.大寒:
                        return SetsugetsuKind.十二月;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public RokuyoKind Rokuyo
        {
            get
            {
                return (RokuyoKind)((this.OldMonth + this.OldDay) % Enum.GetValues(typeof(RokuyoKind)).Length);
            }
        }

        public JunichokuKind Junichoku
        {
            get
            {
                return (JunichokuKind)((Math.Ceiling(this.JulianDay) - (int)this.Setsugetsu) % Enum.GetValues(typeof(JunichokuKind)).Length);
            }
        }

        public NijuhashukuKind Nijuhashuku
        {
            get
            {
                return (NijuhashukuKind)((this.ModifiedJulianDay - 8) % Enum.GetValues(typeof(NijuhashukuKind)).Length);
            }
        }

        public StarSignKind StarSign
        {
            get
            {
                return CalendarService.GetKind(
                    this.Source,
                    CalendarService.AdjustDate(this.Source, BasisDate.StarSign));
            }
        }

        static CalendarModel()
        {
            _cultureInfo.DateTimeFormat.Calendar = _calendar;
        }

        public CalendarModel()
        {
        }

        public CalendarModel(DateTime date) : base()
        {
            this.Update(date);
        }

        public void Update(DateTime date)
        {
            var tmp = _lunisolarCalendar.AddDays(date, 1 - _lunisolarCalendar.GetDayOfYear(date));
            var oldMonth = _lunisolarCalendar.GetMonth(date);
            var oldDay = _lunisolarCalendar.GetDayOfMonth(date);
            var leapMonth = _lunisolarCalendar.GetLeapMonth(_lunisolarCalendar.GetYear(tmp), _lunisolarCalendar.GetEra(tmp));
            if (0 < leapMonth && leapMonth <= oldMonth)
            {
                oldMonth--;
            }
            var oldYear = oldMonth <= date.Month ? date.Year : date.AddYears(-1).Year;

            this.Source = date;
            this.OldYear = oldYear;
            this.OldMonth = oldMonth;
            this.OldDay = oldDay;
            this.LeapMonth = leapMonth;

            foreach (var info in this.GetType().GetRuntimeProperties().Where(i => i.CanWrite == false))
            {
                this.RaisePropertyChanged(info.Name);
            }
        }

        private (int year, int month, int day) GetSetsuGiriDate()
        {
            SolarTermKind kind;
            switch (this.Setsugetsu)
            {
                case SetsugetsuKind.正月:
                    kind = SolarTermKind.立春;
                    break;
                case SetsugetsuKind.二月:
                    kind = SolarTermKind.啓蟄;
                    break;
                case SetsugetsuKind.三月:
                    kind = SolarTermKind.清明;
                    break;
                case SetsugetsuKind.四月:
                    kind = SolarTermKind.立夏;
                    break;
                case SetsugetsuKind.五月:
                    kind = SolarTermKind.芒種;
                    break;
                case SetsugetsuKind.六月:
                    kind = SolarTermKind.小暑;
                    break;
                case SetsugetsuKind.七月:
                    kind = SolarTermKind.立秋;
                    break;
                case SetsugetsuKind.八月:
                    kind = SolarTermKind.白露;
                    break;
                case SetsugetsuKind.九月:
                    kind = SolarTermKind.寒露;
                    break;
                case SetsugetsuKind.十月:
                    kind = SolarTermKind.立冬;
                    break;
                case SetsugetsuKind.十一月:
                    kind = SolarTermKind.大雪;
                    break;
                case SetsugetsuKind.十二月:
                    kind = SolarTermKind.小寒;
                    break;
                default:
                    throw new ArgumentException();
            }
            
            (int year, int month, int day) date = (
                this.Year,
                (int)this.Setsugetsu,
                (this.Source - CalendarService.GetRange(this.Source, kind).lower).Days + 1);
            if (this.Month < date.month || 
                this.Month == date.month && this.Day < date.day)
            {
                date.year = this.Year - 1;
            }
            return date;
        }
    }
}