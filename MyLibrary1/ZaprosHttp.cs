using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary1
{
    public class ZaprosHttp
    {  
        public void Mama()
        {
            int ch;
            // Сначала создаем запрос по URI-адресу. 
            Console.Write("URL: ");
            string k = Console.ReadLine();
            HttpWebRequest req = (HttpWebRequest)
            WebRequest.Create(k);

            // Затем отправляем этот запрос и получаем ответ. 

            HttpWebResponse resp = (HttpWebResponse)
            req.GetResponse();

            //Из ответа получаем входной поток. 
            Stream istrm = resp.GetResponseStream();

            /* А теперь считываем и отображаем html-документ, 
            полученный от заданного URI. Текст "не улетит" 
            с экрана, поскольку данные отображаются порциями 
            объемом в 400 символов. Просмотрев очередные 
            400 символов, нажмите клавишу <ENTER> 
            для получения следующей порции документа. */

            for (int i = 1; ; i++)
            {
                ch = istrm.ReadByte();
                if (ch == -1) break;
                Console.Write((char)ch);
                if ((i % 400) == 0)
                {
                    Console.Write("\nНажмите клавишу.");
                    Console.Read();
                }
            }
            // Закрываем поток, содержащий ответ. При этом 
            // автоматически закроется и входной поток istrm. 
            resp.Close();
        }
    }
}

