using System;
using System.Collections.Generic;
using System.Text;

namespace VentilationLib
{
    public class MeasuringProcess
    {
        string[] currentMeasurment;
        Flats mieszkanie { get; set; }
        public Flats MIESZKANIE
        {
            get => mieszkanie;
            set
            {
                mieszkanie = value;
            }
        }
        Addresses adres { get; set; }
        public Addresses ADRES
        {
            get => adres;
            set
            {
                adres = value;
            }
               
        }
        Block blok { get; set; }
        public Block BLOK
        {
            get => blok;
            set
            {
                blok = value;
            }
        }
        DateTime dateOfMeasuring = DateTime.Today;
        FlatsResults flatsResultsList;



        public MeasuringProcess(Login name)
        {
            flatsResultsList = new FlatsResults();
            Console.WriteLine("Zacznij pomiary");
            Console.WriteLine("Wpisz adres");
            adres = new Addresses();
            Console.WriteLine("Wpisz właściwości bloku");
            blok = new Block();
            Console.WriteLine("Zaczynamy pomiary. Wpisz dane pierwszego mieszkania");
            for(int i = 0;i<blok.FLATQIANTITY;i++)
            {
                mieszkanie = new Flats(blok.MAXVENTQUANTITY);
                flatsResultsList.FlatsResultsAdd(mieszkanie);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine(adres);
            Console.WriteLine(blok);
            flatsResultsList.FlatsResultsRead();
            string userAndDate = $"Wykonujący pomiary: {name.LOGINNAME} || Data pomiarów: {dateOfMeasuring.ToString("yyyy/MM/dd")}\n --------------------------------";
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter($@"F:\test\{adres.STREET}{blok.BLOCKNR}{dateOfMeasuring.ToString("yyyyMMdd")}.txt", true))
            
            {
                file.WriteLine(userAndDate);
                file.WriteLine(adres);
                file.WriteLine(blok);
                file.WriteLine(flatsResultsList.ToString());
                
            }
            






        }

        public override string ToString()
        {
            return $"{adres}\n{blok}\n{flatsResultsList.ToString()}";
        }
    }
}
