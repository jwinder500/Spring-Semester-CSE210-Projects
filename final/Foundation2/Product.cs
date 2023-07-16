using System;

namespace Foundation2
{
    public class Product
    {
        public List<string> Name = new List<string>();
        public List<int> Price = new List<int>();
        public List<int> Quantity= new List<int>();
        public void NewProduct(string name, int price, int quantity)
        {
            Name.Add(name);
            Price.Add(price);
            Quantity.Add(quantity);
        }
        public void AddItems(string name, int quantity)
        {
            if (Name.Contains(name))
            {
                int index = Name.IndexOf(name);
                Quantity[index] += quantity;
            }
            else
            {
                Console.WriteLine("Try a different product name.");
            }
        }
        public bool SellProducts(string name, int quantity)
        {
            if (Name.Contains(name))
            {
                int index = Name.IndexOf(name);
                if (Quantity[index]> quantity)
                {
                    Quantity[index] -= quantity;
                    return true;
                }
                else
                {
                    Console.WriteLine("You need more of that product!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Try a different product name.");
                return false;
            }
        }
    }
}