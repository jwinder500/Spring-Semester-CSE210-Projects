using System;

namespace Foundation2
{
    public class Order
    {
        private List<string> products = new List<string>();
        private List<string> customer = new List<string>();
        private int price;
        private string PackingLabel;
        private string ShippingLabel;

        public void CreateNewOrder(string name, string address, string product1, string product2, string product3, int price, bool USA)
        {
            customer.Add(name);
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            PackingLabel = $"{product1}, {product2}, {product3}";
            ShippingLabel = $"{name}, {address}";
            if (USA == true)
            {
                price += 5;
            }
            else
            {
                price += 35;
            }
        }
        public void PrintLabels()
        {
            Console.WriteLine(PackingLabel);
            Console.WriteLine(ShippingLabel);
        }
    }
}