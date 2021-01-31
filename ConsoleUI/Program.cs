using Business.Concrete;
using DataAccess.Concrete.Inmemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new InmemoryProductDal());

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
