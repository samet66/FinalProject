using Business.Abstract;
using DataAccess.Abstart;
using DataAccess.Concrete.Inmemory;
using enities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _IProductDal;

        public ProductManager(IProductDal ıProductDal)
        {
            _IProductDal = ıProductDal;
        }

        public List<Product> GetAll()
        {
            return _IProductDal.GetAll();
        }
    }
}
