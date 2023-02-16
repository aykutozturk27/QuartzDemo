using Ninject.Modules;
using QuartzDemo.Business.Abstract;
using QuartzDemo.Business.Concrete.Managers;
using QuartzDemo.DataAccess.Abstract;
using QuartzDemo.DataAccess.Concrete.InMemory;

namespace QuartzDemo.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICarDal>().To<InMemoryCarDal>().InSingletonScope();
            Bind<ICarService>().To<CarManager>().InSingletonScope();
        }
    }
}
