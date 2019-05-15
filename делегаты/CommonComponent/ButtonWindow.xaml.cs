using System.Windows;

namespace CommonComponent {
    /// <summary>
    /// Логика взаимодействия для ButtonWindow.xaml
    /// </summary>
    public partial class ButtonWindow : Window {
        CounterComponent _counterComponent;

        public ButtonWindow(CounterComponent counterComponent) {
            InitializeComponent();
            _counterComponent = counterComponent;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            _counterComponent.IncreaseCounter();
        }
    }
}
