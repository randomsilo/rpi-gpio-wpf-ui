using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace rpi_gpio_api_wrapper
{
    public class Network
    {
        public static string CallApi(string url)
        {
            string response = "";

            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            using (Stream data = client.OpenRead(url))
            using (StreamReader reader = new StreamReader(data))
            {
                response = reader.ReadToEnd();
            }

            return response;
        }
    }
}
