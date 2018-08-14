namespace rpi_gpio_client
{
    public class DeviceSearch
    {
        public string IpAddress { get; set; }
        public string DeviceStatus { get; set; }

        public DeviceSearch()
        {
            IpAddress = "";
            DeviceStatus = "None";
        }

        public DeviceSearch(string ipAddress, string deviceStatus="None") : this()
        {
            IpAddress = ipAddress;
            DeviceStatus = deviceStatus;
        }
    }
}