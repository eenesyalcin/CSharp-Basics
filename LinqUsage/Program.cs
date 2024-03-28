using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  LINQ USAGE  <-----\n\n");


            List<Category> categories = new List<Category>()
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"},
            };

            List<Product> products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=1, ProductName="ASUS Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=35000, UnitInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="ACER Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=30000, UnitInStock=10},
                new Product{ProductId=3, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=25000, UnitInStock=4},
                new Product{ProductId=4, CategoryId=2, ProductName="SAMSUNG Telefon", QuantityPerUnit="6 GB RAM", UnitPrice=15000, UnitInStock=7},
                new Product{ProductId=5, CategoryId=2, ProductName="APPLE Telefon", QuantityPerUnit="8 GB RAM", UnitPrice=28000, UnitInStock=0},
            };

            Console.WriteLine("Filtering Products With Algorithm");
            Console.WriteLine("__________________________________________________");
            foreach (var product in products)
            {
                if (product.UnitPrice >= 25000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("\n\nFiltering Products With Linq");
            Console.WriteLine("__________________________________________________");
            var result = products.Where(product => product.UnitPrice >= 25000 && product.UnitInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }


            GetProductsWithAlgorithm(products);
            GetProductsWithLinq(products);


            Console.ReadLine();
        }


        static List<Product> GetProductsWithAlgorithm(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice >= 25000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }


        static List<Product> GetProductsWithLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice >= 25000 && product.UnitInStock > 3).ToList();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}