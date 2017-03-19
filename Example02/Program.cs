using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product 豆漿 = new Product();
            豆漿.Name = "永和豆漿";
            豆漿.Price = 15;

            Product 油條 = new Product();
            油條.Name = "好吃油條";
            油條.Price = 10;

            Customer Apple = new Customer();
            Apple.ID = 1;
            Apple.Name = "AppleSun";

            Order 訂單 = new Order();
            訂單.Customer = Apple;
            訂單.ID = 1;
            訂單.ProductList.Add(豆漿);
            訂單.ProductList.Add(油條);
        }
    }
}