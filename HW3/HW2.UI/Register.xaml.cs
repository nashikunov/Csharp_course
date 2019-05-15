using System.Windows;
using HW2.Core.user;

namespace HW2.Core
{
    public partial class Register
    {
        private readonly UserRegistry _userRegistry;

        public Register(UserRegistry userRegistry) : this()
        {
            _userRegistry = userRegistry;
        }

        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var valid = true;

            var username = Username.Text;
            var email = Email.Text;

            if (Password.Password.Equals(""))
            {
                valid = false;
                MessageBox.Show("Empty password");
            }

            var password = PasswordHelper.GetHash(Password.Password);
            var passwordConfirmation = PasswordHelper.GetHash(PasswordConfirmation.Password);

            if (username.Equals(""))
            {
                valid = false;
                MessageBox.Show("Empty username");
            }

            if (email.Equals(""))
            {
                valid = false;
                MessageBox.Show("Empty email");
            }

            if (!password.Equals(passwordConfirmation))
            {
                valid = false;
                MessageBox.Show("Password and password confirmation are not equal");
            }

            if (!valid) return;

            if (_userRegistry.IsUsernameExists(Username.Text) || _userRegistry.IsEmailExists(Email.Text))
            {
                MessageBox.Show("User with this username or email already exists");
                return;
            }

            _userRegistry.AddUser(new User()
            {
                Id = _userRegistry.GetNextId(),
                Username = username,
                Email = email,
                Password = password
            });

            MessageBox.Show("Registration succesfull");
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}