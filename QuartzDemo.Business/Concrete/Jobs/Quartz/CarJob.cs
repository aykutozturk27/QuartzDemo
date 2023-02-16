using Quartz;
using QuartzDemo.Business.Abstract;
using QuartzDemo.Business.DependencyResolvers.Ninject;

namespace QuartzDemo.Business.Concrete.Jobs.Quartz
{
    public class CarJob : IJob
    {
        private readonly ICarService _carService;
        public CarJob()
        {
            _carService = InstanceFactory.GetInstance<ICarService>();
        }

        public Task Execute(IJobExecutionContext context)
        {
            var carList = _carService.GetAll();
            foreach (var item in carList)
            {
                Console.WriteLine(item.Description);
                Console.WriteLine(item.DailyPrice);
                Console.WriteLine(item.ModelYear);
                Console.WriteLine("-------------------------------");
            }
            return Task.FromResult(carList);
        }
    }
}
