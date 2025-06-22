using System;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample product list
            List<Product> products = new List<Product>
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Shoes", "Fashion"),
                new Product(3, "Headphones", "Electronics"),
                new Product(4, "Coffee Maker", "Home Appliances"),
                new Product(5, "Notebook", "Stationery")
            };

            Console.WriteLine("🔍 Linear Search:");
            var result1 = SearchAlgorithms.LinearSearch(products, "Shoes");
            Console.WriteLine(result1 != null ? result1.ToString() : "Product not found");

            Console.WriteLine("\n🔍 Binary Search (by ProductName):");
            var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
            var result2 = SearchAlgorithms.BinarySearch(sortedProducts, "Shoes");
            Console.WriteLine(result2 != null ? result2.ToString() : "Product not found");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
