using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Concrete.InMemory;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Varsa iş kodlarını buraya yazarız. (yetkisi var mı vs tarzında if clauses.)
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategory(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }
        
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice >= min && p.UnitPrice<=max);
        }
    }
}
