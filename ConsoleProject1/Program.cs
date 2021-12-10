//using ConsoleProject1.Classes;
// using ConsoleProject1.Interfaces;
using System;
using MyLibrary1;

namespace ConsoleProject1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Работа с консолью";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
 
            Console.WriteLine("***********************************************");
            Console.WriteLine("ОГЛАВЛЕНИЕ");
            Console.WriteLine("***********************************************\r\n");
            Console.WriteLine("DNS - 0");
            Console.WriteLine("Вывод страницы - 1");
            Console.WriteLine("Данные по серверу - 2");
            Console.WriteLine("Выход - 10 и ESC\r\n");
            Console.WriteLine("***********************************************");

        Label:
            Console.Write("Выбор:");
            string k = Console.ReadLine();
            switch (k)
            {
                case "0":
                    Console.WriteLine("DNS");
                    ZaprosDns zaprosDns = new ZaprosDns();
                    zaprosDns.Mdns();
                    Console.ReadKey();
                    goto Label;

                case "1":
                    Console.WriteLine("HTML page");
                    ZaprosHttp zaprosHttp = new ZaprosHttp();
                    zaprosHttp.Mama();
                    Console.ReadKey();
                    goto Label;

                case "2":
                    Console.WriteLine("Server");
                    ZaprosHeager zaprosHeager = new ZaprosHeager();
                    zaprosHeager.Mheader();
                    Console.ReadKey();
                    goto Label;

                case "10":
                    Console.Clear();
                    break;
            }
            /*
            // Print
            ConsolShow consoleshow = new ConsolShow();
            Console.Write("Введите Name: ");
            string n = Console.ReadLine();
            consoleshow.Pr2(n);
            */
            Console.ReadKey();

        }
    }
}
