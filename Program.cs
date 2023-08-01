using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Product A", Price = 100, Stock = 5 },
            new Product { Name = "Product B", Price = 200, Stock = 3 },
            new Product { Name = "Product C", Price = 50, Stock = 10 }
        };

        string sortKey = "name";
        bool ascending = true;

        InventoryManager manager = new InventoryManager();
        List<Product> sortedProducts = manager.SortProducts(products, sortKey, ascending);

        foreach (Product product in sortedProducts)
        {
            Console.WriteLine($"{{\"name\": \"{product.Name}\", \"price\": {product.Price}, \"stock\": {product.Stock}}}");
        }
    }
}

