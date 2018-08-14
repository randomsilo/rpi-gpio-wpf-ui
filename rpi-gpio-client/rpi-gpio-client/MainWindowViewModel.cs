using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpi_gpio_client
{
    public class MainWindowViewModel
    {
        public FindDevicesViewModel FindDevicesViewModel { get; set; }

        public MainWindowViewModel()
        {
            FindDevicesViewModel = new FindDevicesViewModel();
        }


    }
}
