using HW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace HW
{
    /// <summary>
    /// Логика взаимодействия для TableWindow.xaml
    /// </summary>
    public partial class TableWindow : Window
    {
        List<Route> Routes = new List<Route>();
        List<Favourite> FavouriteRoutes = new List<Favourite>();
        public event Action<List<Favourite>> NewFavsAcc;
        IBus _bus = new Data();
        //IRoutesReader _reader = new SimpleReader(); json



        public TableWindow(List<Favourite> FavAcc, List<Route> _routes)
        {
            InitializeComponent();

            Routes = _routes;
            List<string> Names = new List<string>();
            foreach (var route in Routes)
                Names.Add(route.Name);



            comboBoxRoutes.ItemsSource = Names;
            FavouriteRoutes = FavAcc;
            if (FavouriteRoutes != null)
            {
                FavButton.IsEnabled = true;
            }


        }

        private void ButtonOkRoute_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxRoutes.SelectedItem == null)
                return;
            List<string> st = new List<string>();
            foreach (var s in Routes.First(route => route.Name == comboBoxRoutes.Text).Stations)
                st.Add(s.Station.Name);
            comboBoxStops.ItemsSource = st;
            comboBoxStops.IsEnabled = true;
            comboBoxStops.SelectedItem = null;
            OkStopButton.IsEnabled = true;
            comboBoxRoutes.IsEnabled = false;
            OkRouteButton.IsEnabled = false;


        }

        private void ButtonOkStop_Click(object sender, RoutedEventArgs e)
        {
            var route = Routes.First(Route => Route.Name == comboBoxRoutes.Text);
            dataGridTable.ItemsSource = _bus.GetBus(route, comboBoxStops.Text);

        }


        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            comboBoxRoutes.SelectedItem = null;
            comboBoxStops.SelectedItem = null;
            comboBoxStops.IsEnabled = false;
            comboBoxRoutes.IsEnabled = true;
            OkRouteButton.IsEnabled = true;
            OkStopButton.IsEnabled = false;
            dataGridTable.ItemsSource = null;

        }

        private void FavouriteButton_Click(object sender, RoutedEventArgs e)
        {
            List<Bus> Busses = new List<Bus>();
            DateTime time = DateTime.Now;
            foreach (var fav in FavouriteRoutes)
            {
                foreach (var route in Routes)
                {
                    foreach (var st in route.Stations)
                    {
                        if (st.Station.Name == fav.Station.Name)
                        Busses.AddRange(_bus.GetBus(route, fav.Station.Name));
                    }
                }
                
            }

            dataGridTable.ItemsSource = Busses;

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            NewFavsAcc?.Invoke(FavouriteRoutes);
            DialogResult = false;
        }
    }
}
