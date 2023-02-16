using QuartzDemo.Business.Abstract;
using QuartzDemo.DataAccess.Abstract;
using QuartzDemo.Entities.Concrete;

namespace QuartzDemo.Business.Concrete.Managers
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetList();
        }
    }
}
