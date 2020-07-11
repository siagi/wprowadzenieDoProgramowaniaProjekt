using System;
using System.Collections.Generic;
using System.Text;

namespace VentilationLib
{
    public class Flats
    {
        FlatResultID flatID;
        int flatNumber { get; set; }
        public int FLATNUMBEr
        {
            get => flatNumber;
            set
            {
                flatNumber = value;
            }
        }
        int surface { get; set; }
        public int SURFACE
            {
            get => surface;
            set
            {
                surface = value;
            }
            }

        int ventsNumbers { get; set; }
        public int VENTSNUMBER
        {
            get => ventsNumbers;
            set
            {
                ventsNumbers = value;
            }
        }
        public List<int> measurements;
        bool measurementSuccess;
        string comments { get; set; }
        public string COMMENTS
        {
            get => comments;
            set
            {
                comments = value;
            }
        }

        public Flats(int flatNumber, int surface, int ventsNumbers, List<int> measurements, bool measurementSuccess, string comments)
        {
            this.flatNumber = flatNumber;
            this.surface = surface;
            this.ventsNumbers = ventsNumbers;
            this.measurements = measurements;
            this.measurementSuccess = measurementSuccess;
            this.comments = comments;
        }
        

        public Flats(int maxVentQuantity)
        {
            Console.WriteLine("Podaj nr mieszkania");
            this.flatNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj powierzchnie mieszkania");
            this.surface = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilosc wentylatorow w mieszkaniu");
            this.ventsNumbers = int.Parse(Console.ReadLine());
            if (this.ventsNumbers <= maxVentQuantity)
                measurements = new List<int>();
            else 
            {
                Console.WriteLine("Wpisna została za duża ilość wentylatorów w mieszkaniu - spróbuj ponownie");
                while(this.ventsNumbers>maxVentQuantity)
                {
                    Console.WriteLine("Podaj poprawną ilość wentylatorów w mieszkaniu");
                    this.ventsNumbers = int.Parse(Console.ReadLine());
                }
                measurements = new List<int>();
            }
            for(int i=0;i<this.ventsNumbers;i++)
            {
                Console.WriteLine($"Podaj wartość pomiaru dla wentylatora {i+1}");
                measurements.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Czy udało się wykonać pomiary ? TAK/NIE");
            string measurementSuccessAnswer = Console.ReadLine();
            if (measurementSuccessAnswer == "TAK")
            { measurementSuccess = true; }
            else { measurementSuccess = false; }
            Console.WriteLine("Komentarz:");
            this.comments = Console.ReadLine();
            flatID = new FlatResultID();
            
           

        }

        public override string ToString()
        {
            string result = $"Nr mieszknia: {flatNumber} || Powierzchnia: {surface} m2 || ";
            int count = 1;
            foreach(int measurement in measurements)
            {
                result += $"Wentylator {count} -- {measurement} m3/h || ";
                count++;
            }
            return result + $"Uwagi: {comments} || ID pomiaru: {this.flatID.IDTEXT} ";

            
        }
    }
}
