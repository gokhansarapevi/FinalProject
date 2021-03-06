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
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var VARIABLE in categoryManager.GetAll().Data)
            {
                Console.WriteLine(VARIABLE.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
            //Console.WriteLine("****All Products Listing****");
            //foreach (var item in productManager.GetAll())
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //Console.WriteLine("****Products With CategoryId value of '3' Listing****");
            //foreach (var product in productManager.GetAllByCategory(3))
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //Console.WriteLine("******Unit Price Between 10 and 100******");
            //foreach (var product in productManager.GetByUnitPrice(10, 100))
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "----" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
                
            }
        }
    }
}
