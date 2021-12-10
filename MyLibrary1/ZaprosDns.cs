using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary1
{
    public class ZaprosDns
    {
        public void Mdns()
        {
            Console.Write("URL: ");
            string k = Console.ReadLine();

            IPAddress[] array = Dns.GetHostAddresses(k);
            foreach (IPAddress ip in array)
            {
                Console.WriteLine(ip.ToString());
            }
        }
    }
}

