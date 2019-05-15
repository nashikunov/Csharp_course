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

namespace ComponentInteraction
{
    public delegate void ClickCounterCallback(int counter); //делегат как шаблон метода // экземпляр делегата
    /// <summary>
    /// Логика взаимодействия для ButtonWindow.xaml
    /// </summary>
    public partial class ButtonWindow : Window
    {
        //public MainWindow MainWindow { get; set; }

        //public event ClickCounterCallback OnCounterChanged; //event?

        //int _count = 0;

        ClickCounter _counter;

        public ButtonWindow(ClickCounter counter)
        {
            InitializeComponent();
            _counter = counter;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Title = "Button clicked";
            _counter.IncreaseCounter();
            
            //_count++;
            //OnCounterChanged?.Invoke(_count); //invoke?
        
        }
    }
}
