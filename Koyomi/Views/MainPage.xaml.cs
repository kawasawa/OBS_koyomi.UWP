using Koyomi.ViewModels;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Koyomi.Views
{
    public sealed partial class MainPage : Page
    {
        private bool _isInUpdate = false;
        public MainPageViewModel ViewModel { get; } = new MainPageViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            this.UpdateDate(DateTime.Today);
        }

        private void UpdateDate(DateTime dateTime)
        {
            if (this._isInUpdate)
            {
                return;
            }

            try
            {
                this._isInUpdate = true;
                var offset = new DateTimeOffset(dateTime);
                this.datePicker1.Date = offset;
                this.datePicker2.Date = offset;
                this.calendarView.SelectedDates.Clear();
                this.calendarView.SelectedDates.Add(offset);
                this.calendarView.SetDisplayDate(offset);
                this.calendarView.DisplayMode = CalendarViewDisplayMode.Month;
                this.ViewModel.Update(dateTime);
            }
            finally
            {
                this._isInUpdate = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.UpdateDate(DateTime.Today);
        }

        private void DatePicker_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            this.UpdateDate(e.NewDate.DateTime);
        }

        private void CalendarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            if (args.AddedDates.Count <= 0)
            {
                if (args.RemovedDates.Count <= 0)
                {
                    return;
                }
                this.UpdateDate(args.RemovedDates[0].DateTime);
                return;
            }
            this.UpdateDate(args.AddedDates[0].DateTime);
        }
    }
}
