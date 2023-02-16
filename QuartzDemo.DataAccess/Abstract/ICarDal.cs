using QuartzDemo.Entities.Concrete;

namespace QuartzDemo.DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetList();
    }
}
