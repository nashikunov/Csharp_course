using HW.Helpers;
using HW.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для NewAccountWindow.xaml
    /// </summary>
    public partial class NewAccountWindow : Window
    {
        public User NewAccount { get; set; }
        ISecurity security;

        public NewAccountWindow(ISecurity _security)
        {
            InitializeComponent();
            textBoxLogin.Focus();
            security = _security;
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            textBoxLogin.Focus();
            if (textBoxLogin.Text.Trim().Length == 0 || textBoxPassword.Text.Trim().Length == 0 || textBoxPasswordRep.Text.Trim().Length == 0)
                return;
            if (textBoxLogin.Text.Length <= 4 || textBoxPassword.Text.Length <= 4)
            {
                MessageBox.Show("Your login and password must contain at least five characters!");
                textBoxLogin.Text = null;
                textBoxPassword.Text = null;
                textBoxPasswordRep.Text = null;
                return;
            }
            if (textBoxPassword.Text != textBoxPasswordRep.Text)
            {
                MessageBox.Show("Your passwords don't match!");
                textBoxLogin.Text = null;
                textBoxPassword.Text = null;
                textBoxPasswordRep.Text = null;
                return;
            }

            NewAccount = new User
            {
                Login = textBoxLogin.Text.Trim(),
                Password = security.GetHash(textBoxPassword.Text.Trim())
            };

            DialogResult = false;
        }
    }
}
