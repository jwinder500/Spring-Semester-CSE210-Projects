using System;

namespace Foundation2
{
    public class Customer
    {
        private string Name;
        public Address address = new Address();

        public void ChangeName(string name)
        {
            Name = name;
        }
        public bool USA()
        {
            string US = "USA";
            string Country = address.FindCountry();
            if (Country == US)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}