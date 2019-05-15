using HW.Helpers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace HW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window //Работу выполнил Сафонов Николай группа 172
    {
        private Context context = new Context();
        private List<User> _users;
        private List<Station> _stations;
        private List<Route> _routes;
        private GeneralData _generalData = new GeneralData();
        User Account = new User();
        ISecurity _security = new SimplePasswordSecure();


        public MainWindow()
        {
            InitializeComponent();
            _users = context.Users.Include("Favourites").ToList();
            _stations = context.Stations.ToList();
            _routes = context.Routes.Include("Stations").ToList();
            _generalData.Stations = _stations;
            _generalData.Routes = _routes;
            _generalData.Users = _users;
        }

        private void ButtonNewAccount_Click(object sender, RoutedEventArgs e)
        {

            var accountWindow = new NewAccountWindow(_security);
            if (accountWindow.ShowDialog() == false)
            {
                Account = accountWindow.NewAccount;
                foreach (var acc in _users)
                {
                    if (acc.Login == Account.Login)
                    {
                        MessageBox.Show($"There is a user with {Account.Login} login!");
                        return;
                    }
                }
                _generalData.Users.Add(Account);
                DB.Update(_generalData);
                Json.Writer(_generalData);
            }

        }



        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            if (_users.Count == 0)
            {
                MessageBox.Show("Wrong login or password!");
                textBoxLogin.Text = null;
                textBoxPassword.Password = null;
                return;
            }
            if (_users.Any(account => account.Login == textBoxLogin.Text))
            {
                if (_users.Any(account => account.Password == _security.GetHash(textBoxPassword.Password)))
                {
                    var tableWindow = new TableWindow(Account.Favourites, _routes);
                    tableWindow.NewFavsAcc += NewFavouriteRoutes;

                    if (tableWindow.ShowDialog() == false)
                    {

                        textBoxLogin.Text = null;
                        textBoxPassword.Password = null;
                    }

                }
            }
            else
            {
                MessageBox.Show("Wrong login or password!");
                textBoxLogin.Text = null;
                textBoxPassword.Password = null;
                return;
            }


        }
        public void NewFavouriteRoutes(List<Favourite> fav)
        {
            Account.Favourites = fav;
        }



    }
}
