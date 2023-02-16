using QuartzDemo.Core.Entities;

namespace QuartzDemo.Entities.Concrete
{
    public class Car : BaseEntity
    {
        public string? Description { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime ModelYear { get; set; }
    }
}
