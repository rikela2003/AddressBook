﻿using System;
using System.Configuration;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = ConfigurationManager.AppSettings["ApplicationName"];
            Console.WriteLine("WELCOME TO:");
            Console.WriteLine(name);
            Console.WriteLine(new string('-', Console.WindowWidth - 4));
            Console.ReadLine();

            Rolodex rolodex = new Rolodex();
            rolodex.DoStuff();

            //test
        }
    }
}
