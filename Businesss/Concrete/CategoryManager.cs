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
    public class CategoryManager : ICategoryService
    {
        readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this._categoryDal = categoryDal;
        }

        public void Add(Category product)
        {
            throw new NotImplementedException();
        }

        public Category Get(int Id)
        {
            return _categoryDal.Get(c=>c.CategoryId == Id);
        }

        public List<Category> GetAll()
        {
            //business codes
            return _categoryDal.GetAll();
        }

        public List<Category> GetAllByCategoryId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }
    }
}
//Ipoh Coffee
