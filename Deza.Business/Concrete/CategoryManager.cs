using Deza.Business.Abstract;
using Deza.DataAccess.Abstract;
using Deza.DataAccess.Entities;
using System.Collections.Generic;

namespace Deza.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public List<Category> GetByCategory(int categoryId)
        {
            return _categoryDal.GetList(x => x.CategoryId == categoryId);
        }
    }
}
