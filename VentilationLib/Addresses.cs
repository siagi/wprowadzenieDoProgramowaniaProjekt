using System;

namespace VentilationLib
{
    public class Addresses
    {

        private string City;
        public string CITY
        {
            get => City;
            set 
            {
                City = value;
            }
        }
        private string HousingAssociation;
        public string HOUSINGASSOCIATION
        {
            get => HousingAssociation;
            set 
            {
                HousingAssociation = value;
            }
        }
        private string Street;
        public string STREET
        {
            get => Street;
            set
            {
                Street = value;
            }
        }
        private string PostCode;
        public string POSTCODE 
        {
            get => PostCode;
            set
            {
                PostCode = value;
            }
        }

        public Addresses()
        {
            Console.WriteLine("Podaj miasto");
            City = Console.ReadLine();
            Console.WriteLine("Podaj osiedle");
            HousingAssociation = Console.ReadLine();
            Console.WriteLine("Podaj ulice");
            Street = Console.ReadLine();
            Console.WriteLine("Podaj kod pocztowy");
            PostCode = Console.ReadLine();
        }

         
        public override string ToString()
        {
            return $"Osiedle : {HousingAssociation} || Ulica : {Street} || Kod pocztowy : {PostCode} || Miasto :{City}\n --------------------------------";
        }
    }

}
