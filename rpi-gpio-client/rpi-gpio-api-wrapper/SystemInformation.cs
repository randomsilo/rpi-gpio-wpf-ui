using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace rpi_gpio_api_wrapper
{
    public class SystemInformation
    {

        public static string GetSystemInformation(string host, int port)
        {
            string url = string.Format("https://{0}:{1}/{2}", host, port, "info");
            return Network.CallApi(url);
        }
    }
}
