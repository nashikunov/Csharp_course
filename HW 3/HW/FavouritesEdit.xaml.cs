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
using TransportApp;

namespace HW
{
    /// <summary>
    /// Логика взаимодействия для FavouritesEdit.xaml
    /// </summary>
    public partial class FavouritesEdit : Window
    {
        public event Action<List<FavouriteData>> NewFavs;
        List<FavouriteData> FavRoutes = new List<FavouriteData>();
        List<RoutesData> Routes = new List<RoutesData>();
        public FavouritesEdit(List<RoutesData> routes)
        {
            InitializeComponent();   
            
            Routes = routes;
            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(bus11checkBox.IsChecked == true)
            {
                List<string> list1 = new List<string>();
                if(checkBox11_1.IsChecked == true)
                {
                    list1.Add(checkBox11_1.Content.ToString());
                }
                if (checkBox11_2.IsChecked == true)
                {
                    list1.Add(checkBox11_2.Content.ToString());
                }
                if (checkBox11_3.IsChecked == true)
                {
                    list1.Add(checkBox11_3.Content.ToString());
                }
                if (checkBox11_4.IsChecked == true)
                {
                    list1.Add(checkBox11_4.Content.ToString());
                }
                if (checkBox11_5.IsChecked == true)
                {
                    list1.Add(checkBox11_5.Content.ToString());
                }

                if (list1.Count == 0)
                {
                    MessageBox.Show("You can't choose a bus without stops!");
                    return;
                }
                FavouriteData fav1 = new FavouriteData
                {
                    Bus = Routes.First(route => route.Name == "11"),
                    FavouriteStops = list1

                };
                FavRoutes.Add(fav1);
                
            }

            if (bus23checkBox.IsChecked == true)
            {
                List<string> list2 = new List<string>();
                if (checkBox23_1.IsChecked == true)
                {
                    list2.Add(checkBox23_1.Content.ToString());
                }
                if (checkBox23_2.IsChecked == true)
                {
                    list2.Add(checkBox23_2.Content.ToString());
                }
                if (checkBox23_3.IsChecked == true)
                {
                    list2.Add(checkBox23_3.Content.ToString());
                }
                if (checkBox23_4.IsChecked == true)
                {
                    list2.Add(checkBox23_4.Content.ToString());
                }
                if (checkBox23_5.IsChecked == true)
                {
                    list2.Add(checkBox23_5.Content.ToString());
                }
                if (list2.Count == 0)
                {
                    MessageBox.Show("You can't choose a bus without stops!");
                    return;
                }
                FavouriteData fav2 = new FavouriteData
                {
                    Bus = Routes.First(route => route.Name == "23"),
                    FavouriteStops = list2

                };
                FavRoutes.Add(fav2);

            }

            if (bus605checkBox.IsChecked == true)
            {
                List<string> list3 = new List<string>();
                if (checkBox605_1.IsChecked == true)
                {
                    list3.Add(checkBox605_1.Content.ToString());
                }
                if (checkBox605_2.IsChecked == true)
                {
                    list3.Add(checkBox605_2.Content.ToString());
                }
                if (checkBox605_3.IsChecked == true)
                {
                    list3.Add(checkBox605_3.Content.ToString());
                }
                if (checkBox605_4.IsChecked == true)
                {
                    list3.Add(checkBox605_4.Content.ToString());
                }
                if (checkBox605_5.IsChecked == true)
                {
                    list3.Add(checkBox605_5.Content.ToString());
                }
                if (checkBox605_6.IsChecked == true)
                {
                    list3.Add(checkBox605_6.Content.ToString());
                }
                if (checkBox605_7.IsChecked == true)
                {
                    list3.Add(checkBox605_7.Content.ToString());
                }
                if (list3.Count == 0)
                {
                    MessageBox.Show("You can't choose a bus without stops!");
                    return;
                }
                FavouriteData fav3 = new FavouriteData
                {
                    Bus = Routes.First(route => route.Name == "605"),
                    FavouriteStops = list3

                };
                FavRoutes.Add(fav3);

            }

            if (bus98checkBox.IsChecked == true)
            {
                List<string> list4 = new List<string>();
                if (checkBox98_1.IsChecked == true)
                {
                    list4.Add(checkBox98_1.Content.ToString());
                }
                if (checkBox98_2.IsChecked == true)
                {
                    list4.Add(checkBox98_2.Content.ToString());
                }
                if (checkBox98_3.IsChecked == true)
                {
                    list4.Add(checkBox98_3.Content.ToString());
                }
                if (checkBox98_4.IsChecked == true)
                {
                    list4.Add(checkBox98_4.Content.ToString());
                }
                if (checkBox98_5.IsChecked == true)
                {
                    list4.Add(checkBox98_5.Content.ToString());
                }
                if (checkBox98_6.IsChecked == true)
                {
                    list4.Add(checkBox98_6.Content.ToString());
                }
                if (list4.Count == 0)
                {
                    MessageBox.Show("You can't choose a bus without stops!");
                    return;
                }

                FavouriteData fav4 = new FavouriteData
                {
                    Bus = Routes.First(route => route.Name == "98"),
                    FavouriteStops = list4

                };
                FavRoutes.Add(fav4);
                var y = list4;
            }
            if (FavRoutes.Count == 0)
            {
                MessageBox.Show("Please choose your favourite routes!");
                return;
            }
            NewFavs?.Invoke(FavRoutes);
            DialogResult = false;
            
        }

        private void bus11checkBox_Checked(object sender, RoutedEventArgs e)
        {
            checkBox11_1.IsEnabled = true;
            checkBox11_2.IsEnabled = true;
            checkBox11_3.IsEnabled = true;
            checkBox11_4.IsEnabled = true;
            checkBox11_5.IsEnabled = true;
        }

        private void bus23checkBox_Checked(object sender, RoutedEventArgs e)
        {
            checkBox23_1.IsEnabled = true;
            checkBox23_2.IsEnabled = true;
            checkBox23_3.IsEnabled = true;
            checkBox23_4.IsEnabled = true;
            checkBox23_5.IsEnabled = true;          
        }

        private void bus605checkBox_Checked(object sender, RoutedEventArgs e)
        {
            checkBox605_1.IsEnabled = true;
            checkBox605_2.IsEnabled = true;
            checkBox605_3.IsEnabled = true;
            checkBox605_4.IsEnabled = true;
            checkBox605_5.IsEnabled = true;
            checkBox605_6.IsEnabled = true;
            checkBox605_7.IsEnabled = true;
        }

        private void bus98checkBox_Checked(object sender, RoutedEventArgs e)
        {
            checkBox98_1.IsEnabled = true;
            checkBox98_2.IsEnabled = true;
            checkBox98_3.IsEnabled = true;
            checkBox98_4.IsEnabled = true;
            checkBox98_5.IsEnabled = true;
            checkBox98_6.IsEnabled = true;
        }
       
    }
}
