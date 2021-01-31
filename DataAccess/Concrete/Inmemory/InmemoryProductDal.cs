using DataAccess.Abstart;
using enities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.Inmemory
{
    public class InmemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InmemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product
                {
                CategoryID = 1,
                ProductId = 2,
                UnitInStock = 116,
                UnitPrice = 222.3m,
                ProductName = "Camera"
                },
                new Product
                {
                CategoryID = 2,
                ProductId = 2,
                UnitInStock = 6,
                UnitPrice = 16000,
                ProductName = "telefon"
                },
                new Product
                {
                CategoryID = 2,
                ProductId = 3,
                UnitInStock = 616,
                UnitPrice = 20,
                ProductName = "Klavye"
                }
            };

        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);


            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return  _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürünID'ye sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.CategoryID = product.CategoryID;

        }
    }
}
