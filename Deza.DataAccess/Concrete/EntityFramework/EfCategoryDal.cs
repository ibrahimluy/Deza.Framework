using Deza.DataAccess.Abstract;
using Deza.DataAccess.Concrete.EntityFramework.Contexts;
using Deza.DataAccess.Entities;
using Deza.Stone;

namespace Deza.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
