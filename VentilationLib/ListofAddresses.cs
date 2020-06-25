using System;
using System.Collections.Generic;
using System.Text;

namespace VentilationLib
{
   public class ListofAddresses
    {
        List<Addresses> listOfMainAddresses;

        public ListofAddresses()
        {
            listOfMainAddresses = new List<Addresses>();
        }

        public void addNewMainAddress(string city, string housingAssociation, string street, string postCode)
        {
            Addresses a = new Addresses(city, housingAssociation, street, postCode);
            listOfMainAddresses.Add(a);
        }
        public void readAddresses()
        {
            for (int i = 0; i < listOfMainAddresses.Count; i++)
            {
                Console.WriteLine($"{listOfMainAddresses[i]}");
            }
        }
    }
}
