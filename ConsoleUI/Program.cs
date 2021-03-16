using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("****All Products Listing****");
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("****Products With CategoryId value of '3' Listing****");
            foreach (var product in productManager.GetAllByCategory(3))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("******Unit Price Between 10 and 100******");
            foreach (var product in productManager.GetByUnitPrice(10,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
