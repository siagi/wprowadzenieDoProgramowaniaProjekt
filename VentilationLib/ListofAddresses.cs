using System;
using System.Collections.Generic;
using System.Text;

namespace VentilationLib
{
   public class ListofAddresses
    {
        List<Addresses> listOfMainAddresses { get; set; }
        public List<Addresses> LISTOFMAINADDRESSES
        {
            get => listOfMainAddresses;
            set
            {
                listOfMainAddresses = value;
            }
        }

        public ListofAddresses(List<Addresses> listOfMainAddresses)
        {
            listOfMainAddresses = new List<Addresses>();
        }

        public void addNewMainAddress()
        {
            bool exitloop = true;
            while(exitloop == true)
            {
                Console.WriteLine($"Jeżeli chcesz dodać adres wpisz 1 jeżeli chcesz zakończyc wpisz 0");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine($"Podaj miasto");
                        string city = Console.ReadLine();
                        Console.WriteLine($"Podaj wspólnote");
                        string housingAssociation = Console.ReadLine();
                        Console.WriteLine($"Podaj ulice");
                        string street = Console.ReadLine();
                        Console.WriteLine($"Podaj kod pocztowy");
                        string postCode = Console.ReadLine();
                        Addresses a = new Addresses();
                        listOfMainAddresses.Add(a);
                        break;
                    case "0":
                        exitloop = false;
                        break;
                }
                
            } 

        }
        public void readAddresses()
        {
            for (int i = 0; i < listOfMainAddresses.Count; i++)
            {
                Console.WriteLine($"{i} -- {listOfMainAddresses[i]}");
            }
        }
        
        
    }
}
