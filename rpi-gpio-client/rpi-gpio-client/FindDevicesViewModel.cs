using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpi_gpio_client
{
    public class FindDevicesViewModel
    {
        public string IpAddressStart { get; set; }
        public string IpAddressEnd { get; set; }
        public ObservableCollection<DeviceSearch> DeviceSearchList { get; set; }

        public FindDevicesViewModel()
        {
            IpAddressStart = "192.168.1.3";
            IpAddressEnd = "192.168.1.40";
            DeviceSearchList = new ObservableCollection<DeviceSearch>();
        }

        public void DefineDeviceSearchList()
        {
            // validate start ip
            // validate end ip
            // check start < end

            DeviceSearchList.Clear();

            var ipStartPieces = IpAddressStart.Split('.');
            int startRange = int.Parse(ipStartPieces[3]);

            var ipEndPieces = IpAddressEnd.Split('.');
            int endRange = int.Parse(ipEndPieces[3]);

            string firstpart = string.Format("{0}.{1}.{2}", ipStartPieces[0], ipStartPieces[1], ipStartPieces[2]);
            for(int i=startRange; i<=endRange;i++)
            {
                string ipAddress = string.Format("{0}.{1}", firstpart, i);
                DeviceSearchList.Add(new DeviceSearch(ipAddress));
            }
        }

    }    
}
