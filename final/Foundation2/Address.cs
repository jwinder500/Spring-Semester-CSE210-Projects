using System;

namespace Foundation2
{
    public class Address
    {
        private int StreetNumber;
        private string Street;
        private string City;
        private string State;
        private string Country;
        private int Zip;

        public void ChangeAddress(int StrNum, string Str, string Cit, string Sta, string Cou, int zip)
        {
            StreetNumber = StrNum;
            Street = Str;
            City = Cit;
            State = Sta;
            Country = Cou;
            Zip = zip;
        }

        public void DisplayAddress()
        {
            Console.WriteLine($"{StreetNumber} {Street}, {City}, {State} {Country} {Zip}");
        }
        public string FindCountry()
        {
            return Country;
        }
    }
}