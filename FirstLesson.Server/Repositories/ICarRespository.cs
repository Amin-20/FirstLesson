using FirstLesson.Server.Entities;

namespace FirstLesson.Server.Repositories
{
    public interface ICarRespository
    {
        public Task<List<Car>> GetCars();
    }
}
