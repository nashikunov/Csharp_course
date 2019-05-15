using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using HW2.Core.json;
using HW2.Core.transport;

namespace HW2.Core
{
    public partial class Schedule
    {
        private readonly TimetableCalculator _timetableCalculator;

        public Schedule()
        {
            InitializeComponent();
            var timer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 0, 1)
            };
            timer.Tick += DispatcherTimer_Tick;
            timer.Start();
            
            var stationRegistry = new StationRegistry();
            _timetableCalculator = new TimetableCalculator(stationRegistry);

            Station.IsEnabled = true;
            Station.ItemsSource = stationRegistry.GetStations().Select(station => station.Name);
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now;

            CurrentTime.Text = currentTime.Second % 2 == 0
                ? $"{currentTime:HH}:{currentTime:mm}"
                : $"{currentTime:HH} {currentTime:mm}";
        }

        private void FillTimetable(string stationName)
        {
            var currentTime = DateTime.Now;
            var timetable = _timetableCalculator.GetTimetableForStation(currentTime, stationName);

            timetable.Sort((first, second) => first.WaitingTime - second.WaitingTime);

            Timetable.ItemsSource = timetable;
        }

        private void GetSchedule_Click(object sender, EventArgs e)
        {
            if (Station.SelectedItem != null) FillTimetable(Station.Text);
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Station_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Station.SelectedItem != null) GetSchedule.IsEnabled = true;
        }
    }
}