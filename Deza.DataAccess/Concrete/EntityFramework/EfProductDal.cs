using Deza.DataAccess.Abstract;
using Deza.DataAccess.Concrete.EntityFramework.Contexts;
using Deza.DataAccess.Entities;
using Deza.Stone;

namespace Deza.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
