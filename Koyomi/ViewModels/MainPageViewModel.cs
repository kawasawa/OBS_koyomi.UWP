using Koyomi.Models;
using Koyomi.Common;
using Prism.Windows.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Reactive.Disposables;

namespace Koyomi.ViewModels
{
    public class MainPageViewModel : ViewModelBase, IDisposable
    {
        private readonly CompositeDisposable _disposable = new CompositeDisposable();
        private readonly CalendarModel _calendar = new CalendarModel(new DateTime(2000, 1, 1));

        public DateTimeOffset MinDate { get; } = new DateTimeOffset(SystemValues.LOWER_DATE);
        public DateTimeOffset MaxDate { get; } = new DateTimeOffset(SystemValues.UPPER_DATE);

        public ReactiveProperty<int> Year { get; }
        public ReactiveProperty<int> Month { get; }
        public ReactiveProperty<int> Day { get; }
        public ReactiveProperty<int> DayOfYear { get; }
        public ReactiveProperty<int> OldYear { get; }
        public ReactiveProperty<int> OldMonth { get; }
        public ReactiveProperty<int> OldDay { get; }
        public ReactiveProperty<int> LeapMonth { get; }
        public ReactiveProperty<int> SetsuYear { get; }
        public ReactiveProperty<int> SetsuMonth { get; }
        public ReactiveProperty<int> SetsuDay { get; }
        public ReactiveProperty<string> EraName { get; }
        public ReactiveProperty<int> EraYear { get; }
        public ReactiveProperty<double> JulianDay { get; }
        public ReactiveProperty<double> ModifiedJulianDay { get; }
        public ReactiveProperty<int> MoonAge { get; }
        public ReactiveProperty<JpMonthKind> JpMonth { get; }
        public ReactiveProperty<JpDayOfWeekKind> JpDayOfWeek { get; }
        public ReactiveProperty<FourSeasonKind> FourSeason { get; }
        public ReactiveProperty<SolarTermKind> SolarTerm { get; }
        public ReactiveProperty<SolarTermMicroKind> SolarTermMicro { get; }
        public ReactiveProperty<JikkanKind> JikkanOfYear { get; }
        public ReactiveProperty<JunishiKind> JunishiOfYear { get; }
        public ReactiveProperty<JikkanKind> JikkanOfMonth { get; }
        public ReactiveProperty<JunishiKind> JunishiOfMonth { get; }
        public ReactiveProperty<JikkanKind> JikkanOfDay { get; }
        public ReactiveProperty<JunishiKind> JunishiOfDay { get; }
        public ReactiveProperty<SetsugetsuKind> Setsugetsu { get; }
        public ReactiveProperty<RokuyoKind> Rokuyo { get; }
        public ReactiveProperty<JunichokuKind> Junichoku { get; }
        public ReactiveProperty<NijuhashukuKind> Nijuhashuku { get; }
        public ReactiveProperty<StarSignKind> StarSign { get; }

        public ReactiveProperty<DateTime> FourSeasonLower { get; } = new ReactiveProperty<DateTime>();
        public ReactiveProperty<DateTime> FourSeasonUpper { get; } = new ReactiveProperty<DateTime>();
        public ReactiveProperty<DateTime> SolarTermLower { get; } = new ReactiveProperty<DateTime>();
        public ReactiveProperty<DateTime> SolarTermUpper { get; } = new ReactiveProperty<DateTime>();
        public ReactiveProperty<DateTime> SolarTermMicroLower { get; } = new ReactiveProperty<DateTime>();
        public ReactiveProperty<DateTime> SolarTermMicroUpper { get; } = new ReactiveProperty<DateTime>();
        public ReactiveProperty<DateTime> StarSignLower { get; } = new ReactiveProperty<DateTime>();
        public ReactiveProperty<DateTime> StarSignUpper { get; } = new ReactiveProperty<DateTime>();

        public MainPageViewModel()
        {
            this.Year = this._calendar.ObserveProperty(x => x.Year)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.Month = this._calendar.ObserveProperty(x => x.Month)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.Day = this._calendar.ObserveProperty(x => x.Day)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.DayOfYear = this._calendar.ObserveProperty(x => x.DayOfYear)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.OldYear = this._calendar.ObserveProperty(x => x.OldYear)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.OldMonth = this._calendar.ObserveProperty(x => x.OldMonth)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.OldDay = this._calendar.ObserveProperty(x => x.OldDay)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.LeapMonth = this._calendar.ObserveProperty(x => x.LeapMonth)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.SetsuYear = this._calendar.ObserveProperty(x => x.SetsuYear)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.SetsuMonth = this._calendar.ObserveProperty(x => x.SetsuMonth)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.SetsuDay = this._calendar.ObserveProperty(x => x.SetsuDay)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.EraName = this._calendar.ObserveProperty(x => x.EraName)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.EraYear = this._calendar.ObserveProperty(x => x.EraYear)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.JulianDay = this._calendar.ObserveProperty(x => x.JulianDay)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.ModifiedJulianDay = this._calendar.ObserveProperty(x => x.ModifiedJulianDay)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.MoonAge = this._calendar.ObserveProperty(x => x.MoonAge)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.JpMonth = this._calendar.ObserveProperty(x => x.JpMonth)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.JpDayOfWeek = this._calendar.ObserveProperty(x => x.JpDayOfWeek)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.FourSeason = this._calendar.ObserveProperty(x => x.FourSeason)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.SolarTerm = this._calendar.ObserveProperty(x => x.SolarTerm)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.SolarTermMicro = this._calendar.ObserveProperty(x => x.SolarTermMicro)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.JikkanOfYear = this._calendar.ObserveProperty(x => x.JikkanOfYear)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.JunishiOfYear = this._calendar.ObserveProperty(x => x.JunishiOfYear)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.JikkanOfMonth = this._calendar.ObserveProperty(x => x.JikkanOfMonth)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.JunishiOfMonth = this._calendar.ObserveProperty(x => x.JunishiOfMonth)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.JikkanOfDay = this._calendar.ObserveProperty(x => x.JikkanOfDay)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.JunishiOfDay = this._calendar.ObserveProperty(x => x.JunishiOfDay)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.Setsugetsu = this._calendar.ObserveProperty(x => x.Setsugetsu)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.Rokuyo = this._calendar.ObserveProperty(x => x.Rokuyo)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.Junichoku = this._calendar.ObserveProperty(x => x.Junichoku)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.Nijuhashuku = this._calendar.ObserveProperty(x => x.Nijuhashuku)
                .ToReactiveProperty()
                .AddTo(this._disposable);
            this.StarSign = this._calendar.ObserveProperty(x => x.StarSign)
                .ToReactiveProperty()
                .AddTo(this._disposable);
        }

        public void Dispose()
        {
            this._disposable.Dispose();
        }

        public void Update(DateTime date)
        {
            this._calendar.Update(date);
            
            var range = CalendarService.GetRange(date, this._calendar.FourSeason);
            this.FourSeasonLower.Value = range.lower;
            this.FourSeasonUpper.Value = range.upper;

            range = CalendarService.GetRange(date, this._calendar.SolarTerm);
            this.SolarTermLower.Value = range.lower;
            this.SolarTermUpper.Value = range.upper;

            range = CalendarService.GetRange(date, this._calendar.SolarTermMicro);
            this.SolarTermMicroLower.Value = range.lower;
            this.SolarTermMicroUpper.Value = range.upper;

            range = CalendarService.GetRange(date, this._calendar.StarSign);
            this.StarSignLower.Value = range.lower;
            this.StarSignUpper.Value = range.upper;
        }
    }
}
