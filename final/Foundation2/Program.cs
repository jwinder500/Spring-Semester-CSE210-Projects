using System;

namespace Foundation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Customer James = new Customer();
            Customer Jacob = new Customer();
            Customer Jack = new Customer();
            Order Order = new Order();

            James.Name = "James";
            Jacob.Name = "Jacob";
            Jack.Name = "Jack";

            James.address.ChangeAddress(1111, "Park Place", "Monopoly", "Idaho", "USA", 87111);
            Jacob.address.ChangeAddress(1234, "Boardwakl", "Monopoly", "Idaho", "USA", 87111);
            Jack.address.ChangeAddress(0000, "Cold Street", "Canada City", "Alberta", "Canada", 8888);

            product.NewProduct("Phone", 1000, 100);
            product.NewProduct("Laptop", 2000, 100);
            product.NewProduct("Tablet", 2000, 100);

            if (product.SellProducts("Phone", 1) == true)
            {
                if (product.SellProducts("Laptop", 1) == true)
                {
                    if (product.SellProducts("Tablet", 1) == true)
                    {
                        Order.CreateNewOrder(James.Name, James.address.DisplayAddress(), "Phone", "Laptop", "Tablet", product.Price[0] + product.Price[1] +product.Price[2], James.USA());
                        Order.PrintLabels();
                    }
                }
            }
            if (product.SellProducts("Phone", 2) == true)
            {
                if (product.SellProducts("Laptop", 2) == true)
                {
                    if (product.SellProducts("Tablet", 1) == true)
                    {
                        Order.CreateNewOrder(Jacob.Name, Jacob.address.DisplayAddress(), "Phone", "Laptop", "Tablet", product.Price[0] + product.Price[1] +product.Price[2], Jacob.USA());
                        Order.PrintLabels();
                    }
                }
            }
            if (product.SellProducts("Phone", 1) == true)
            {
                if (product.SellProducts("Laptop", 2) == true)
                {
                    if (product.SellProducts("Tablet", 2) == true)
                    {
                        Order.CreateNewOrder(Jack.Name, Jack.address.DisplayAddress(), "Phone", "Laptop", "Tablet", product.Price[0] + product.Price[1] +product.Price[2], Jack.USA());
                        Order.PrintLabels();
                    }
                }
            }
        }
    }
}