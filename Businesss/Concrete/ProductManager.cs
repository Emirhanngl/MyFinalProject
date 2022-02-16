using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            this._productDal = productDal;
        }   

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public Product Get(int Id)
        {
            return _productDal.Get(p => p.ProductId == Id);
        }

        public List<Product> GetAll()
        {
            // İş kodları
            // Yetkisi var mı ?
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int Id)
        {
            return _productDal.GetAll(p => p.CategoryId == Id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max).OrderBy(p => p.UnitPrice).ToList();
        }
    }
}
//Ipoh Coffee
