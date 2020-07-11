using System;
using System.Collections.Generic;
using System.Text;

namespace VentilationLib
{
    public class FlatsResults
    {
        List<Flats> flatsResultsList;
        public FlatsResults()
        {
            flatsResultsList = new List<Flats>();
        }
        public void FlatsResultsAdd(Flats flatResult)
        {
            flatsResultsList.Add(flatResult);
        }
        public void FlatsResultsRead()
        {
            for(int i=0; i<flatsResultsList.Count;i++)
            {
                Console.WriteLine($"{flatsResultsList[i]}");
            }
        }
        public void FlatsResultsEdit()
        {
            Console.WriteLine("Edytuj wynik- podaj nr mieszkania do edycji");
            int i = int.Parse(Console.ReadLine());
            flatsResultsList[i-1] = new Flats(flatsResultsList[i-1].measurements.Count);
            
        }

        public override string ToString()
        {
            string result = "";
            for(int i = 0; i < flatsResultsList.Count; i++)
            {
                string text = flatsResultsList[i].ToString();
                result += $"{text}\n";
            }
            return result;
        }
    }

}

