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

namespace nothing
{
    /// <summary>
    /// Логика взаимодействия для NameWindow.xaml
    /// </summary>
    public partial class NameWindow : Window
    {
        public NameWindow()
        {
            InitializeComponent();         
        }

        public void AddGuest(string Name)
        {
            GuestList.Text += $"{Name}, ";
        }
    }
}
