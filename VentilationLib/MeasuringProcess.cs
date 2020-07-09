using System;
using System.Collections.Generic;
using System.Text;

namespace VentilationLib
{
    public class MeasuringProcess
    {
        string[] currentMeasurment;
        public MeasuringProcess()
        {
            Console.WriteLine("Zacznij pomiary");
            Console.WriteLine("Wpisz adres");
            Addresses adres = new Addresses();
            Console.WriteLine("Wpisz właściwości bloku");
            Block blok = new Block();
            Console.WriteLine("Zaczynamy pomiary. Wpisz dane pierwszego mieszkania");
            for(int i = 0;i<blok.FLATQIANTITY;i++)
            {
                Flats mieszkanie = new Flats();
            }




        }

    }
}
