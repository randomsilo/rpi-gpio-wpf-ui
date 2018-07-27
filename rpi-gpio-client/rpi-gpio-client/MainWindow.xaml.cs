using rpi_gpio_api_wrapper;
using System.Windows;

namespace rpi_gpio_client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CallApiBtn_Click(object sender, RoutedEventArgs e)
        {
            CallApiOutput.Text = "";
            CallApiOutput.Text += SystemInformation.GetSystemInformation("192.168.1.13", 8000);
        }
    }
}
