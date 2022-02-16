using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Get(int Id);
        List<Category> GetAllByCategoryId(int Id);
        List<Category> GetByUnitPrice(decimal min, decimal max);
        void Add(Category product);
    }
}
