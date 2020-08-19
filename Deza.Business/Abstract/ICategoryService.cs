using Deza.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deza.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        List<Category> GetByCategory(int categoryId);

    }
}
