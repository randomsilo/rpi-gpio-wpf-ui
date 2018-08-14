using rpi_gpio_api_wrapper;
using System.ComponentModel;
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
            DataContext = new MainWindowViewModel();
        }

        public MainWindowViewModel GetDataContext()
        {
            return (MainWindowViewModel)DataContext;
        }

        private void DeviceSearch_Click(object sender, RoutedEventArgs e)
        {
            GetDataContext().FindDevicesViewModel.DefineDeviceSearchList();
        }
    }
}
