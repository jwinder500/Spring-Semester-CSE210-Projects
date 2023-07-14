using System;

namespace Foundation2
{
    public class Customer
    {
        public string Name;
        public Address address = new Address();
        
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