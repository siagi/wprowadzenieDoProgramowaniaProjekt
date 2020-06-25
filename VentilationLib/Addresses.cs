using System;

namespace VentilationLib
{
    public class Addresses
    {
        public string City { get; private set; }
        public string HousingAssociation { get; private set; }
        public string Street { get; private set; }
        public string PostCode { get; private set; }

        public Addresses(string city, string housingAssociation, string street, string postCode)
        {
            City = city;
            HousingAssociation = housingAssociation;
            Street = street;
            PostCode = postCode;
        }

        public override string ToString()
        {
            return $"{HousingAssociation} {Street} {PostCode} {City}";
        }
    }

}
