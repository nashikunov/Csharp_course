using System.Threading.Tasks;
using System.Windows;

using PrimeFinder.Core;

namespace PrimerFinder.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

        public MainWindow()
		{
			InitializeComponent(); // dispatchertimer? timer span
            
        }

		private async void buttonFind_Click(object sender, RoutedEventArgs e)
		{
            PrimeLocator locator = new PrimeLocator();
            //locator.OnResultReady += Locator_OnResultReady;
            var n = int.Parse(textBoxNumber.Text);

            var task = Task.Factory.StartNew(locator.GetNthPrime, n);

            var result = await task;

            //task continuation
            listBoxPrimes.Items.Add(result);
            buttonFind.IsEnabled = false;
            
            //listBoxPrimes.Items.Add(task.Result);

        }

        //private void Locator_OnResultReady(int result)
        //{
        //    Dispatcher.Invoke(() =>
        //    {
        //        listBoxPrimes.Items.Add(result);
        //        buttonFind.IsEnabled = true;
        //    });
        //}



    }
}
