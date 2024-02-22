using FirstLesson.Server.Dtos;
using FirstLesson.Server.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstLesson.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRespository _carRespository;

        public CarController(ICarRespository carRespository)
        {
            _carRespository = carRespository;
        }

        [HttpGet]
        public async Task<IEnumerable<CarDto>> GetCars()
        {
            var result = await _carRespository.GetCars();
            var dtos = result.Select(c =>
            {
                return new CarDto
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Color = c.Color,
                    Distance = c.Distance,
                    EngineVolume = c.EngineVolume,
                    Model = c.Model,
                    Year = c.Year,
                };
            });
            return dtos;
        }
    }
}
