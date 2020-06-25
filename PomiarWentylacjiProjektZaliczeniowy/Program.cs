using System;
using System.Collections.Generic;
using System.Runtime.Loader;
using VentilationLib;

namespace PomiarWentylacjiProjektZaliczeniowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Witaj w aplikacji pomagającej wykonywanie pomiarów wentylacji w mieszkanich.");
            Addresses myAddress = new Addresses("Krakow", "Prokocim", "Sciegiennego", "30-830");
            ListofAddresses mainAddresses = new ListofAddresses();
            mainAddresses.addNewMainAddress(myAddress.City, myAddress.HousingAssociation, myAddress.Street, myAddress.PostCode);
            Console.WriteLine(myAddress);
            mainAddresses.readAddresses();
        }

    }
}
