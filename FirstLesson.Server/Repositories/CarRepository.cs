using FirstLesson.Server.Data;
using FirstLesson.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstLesson.Server.Repositories
{
    public class CarRepository : ICarRespository
    {
        private readonly CarContext _context;

        public CarRepository(CarContext context)
        {
            _context = context;
        }

        public async Task<List<Car>> GetCars()
        {
            var cars= await _context.Cars.ToListAsync();
            return cars;
        }
    }
}

