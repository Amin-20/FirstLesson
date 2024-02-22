using FirstLesson.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstLesson.Server.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}
