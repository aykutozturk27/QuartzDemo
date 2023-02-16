using QuartzDemo.DataAccess.Abstract;
using QuartzDemo.Entities.Concrete;

namespace QuartzDemo.DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,Description="Otomobil",DailyPrice=50000,ModelYear=DateTime.Now.AddYears(-5)},
                new Car{Id=1,Description="Otomobil",DailyPrice=55000,ModelYear=DateTime.Now.AddYears(-7)},
                new Car{Id=1,Description="Yarış Otomobili",DailyPrice=60000,ModelYear=DateTime.Now.AddYears(-6)},
                new Car{Id=1,Description="Yarış Otomobili",DailyPrice=80000,ModelYear=DateTime.Now.AddYears(-8)},
                new Car{Id=1,Description="Yarış Otomobili",DailyPrice=100000,ModelYear=DateTime.Now.AddYears(-9)}
            };
        }

        public List<Car> GetList()
        {
            return _cars;
        }
    }
}
