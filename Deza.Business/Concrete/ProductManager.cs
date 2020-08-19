using Deza.Business.Abstract;
using Deza.DataAccess.Abstract;
using Deza.DataAccess.Entities;
using Deza.Models.ViewModels;
using Deza.Stone;
using Deza.Stone.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace Deza.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        private readonly ICategoryDal _categoryDal;

        public ProductManager(IProductDal productDal, ICategoryDal categoryDal)
        {
            _productDal = productDal;

            _categoryDal = categoryDal;
        }

        public IResult AddProduct(ProductSaveVM product)
        {
            _productDal.Add(new Product()
            {
                ProductName = product.ProductName,
                CategoryId = product.CategoryId
            });

            return new SuccessResult();
        }

        public IDataResult<List<ProductVM>> GetAll()
        {
            var result = _productDal.GetList().Select(x => new ProductVM()
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName
            }).ToList();

            return new SuccessDataResult<List<ProductVM>>(result);
        }

        public IDataResult<List<ProductVM>> GetByCategory(int categoryId)
        {
            var result = _productDal.GetList(x => x.CategoryId == categoryId).Select(x => new ProductVM()
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName
            }).ToList();

            return new SuccessDataResult<List<ProductVM>>(result);
        }

        public IDataResult<ProductVM> GetProduct(int productId)
        {
            var tempResult = _productDal.Get(x => x.ProductId == productId);

            var result = PocoUtils.Convert<Product, ProductVM>(tempResult);

            return new SuccessDataResult<ProductVM>(result);
        }

        public IDataResult<ProductSaveVM> InitializeProduct()
        {
            var tempResult = new ProductSaveVM();

            tempResult.CategoryList = _categoryDal.GetList().Select(x => new SelectModel()
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }).ToList();

            return new SuccessDataResult<ProductSaveVM>(tempResult);
        }
    }
}
