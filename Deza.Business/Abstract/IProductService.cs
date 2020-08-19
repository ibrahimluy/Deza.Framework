using Deza.Models.ViewModels;
using Deza.Stone;
using System.Collections.Generic;

namespace Deza.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<ProductVM>> GetAll();

        IDataResult<List<ProductVM>> GetByCategory(int categoryId);

        IDataResult<ProductVM> GetProduct(int productId);

        IDataResult<ProductSaveVM> InitializeProduct();

        IResult AddProduct(ProductSaveVM product);
    }
}
