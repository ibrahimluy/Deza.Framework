using Autofac;
using Deza.Business.Abstract;
using Deza.Business.Concrete;
using Deza.DataAccess.Abstract;
using Deza.DataAccess.Concrete.EntityFramework;

namespace Deza.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();

            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

        }
    }
}
