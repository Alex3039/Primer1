using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyLibrary1
{
    public class ZaprosHeager
    {
        public async void Mheader()
        {
            Console.Write("URL: ");
            string k = Console.ReadLine();

            try
            {
                
                using var client = new HttpClient();
                var result2 = await client.GetAsync(k);  // Headers
                var result3 = await client.GetStringAsync(k);
                Console.WriteLine(result2);
             //   Rootobject yourObject = JsonConvert.DeserializeObject<Rootobject>(result3);
              //  var name = yourObject.Property1[0].name[0];
               // var content = yourObject.Category[0].content[0];
               // Console.WriteLine( "Name - {0}" + "\r\n" + "Content - {1}"  + "\r\n", name, content);
              //  Console.WriteLine(yourObject.Property1[1].name);
                
                Console.WriteLine(result3);
                var yourObject = JsonConvert.DeserializeObject<Category>(result3);
                Console.WriteLine( "Name - {0}" + "\r\n" + "Content - {1}"  + "\r\n", yourObject.name, yourObject.content);
                /*
                foreach ( var resultsItem in yourObject)
                {
                    Console.WriteLine(resultsItem.id + "-" + resultsItem.name + "-" + resultsItem.title +
                           "-" + resultsItem.kw);
                }
                */




            }
            catch (WebException e)
            {
                Console.WriteLine("WebException: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            Console.WriteLine("Запрос завершен...");
            Console.Read();
        }
    }
}
