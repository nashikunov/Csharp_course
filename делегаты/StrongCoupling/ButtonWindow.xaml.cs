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

namespace StrongCoupling {
    /// <summary>
    /// Логика взаимодействия для ButtonWindow.xaml
    /// </summary>
    public partial class ButtonWindow : Window {
        MainWindow _mainWindow;
        int _clickCount = 0;

        public ButtonWindow(MainWindow mainWindow) {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            _clickCount++;
            _mainWindow.IncreaseCounter(_clickCount);
        }
    }
}
