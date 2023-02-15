using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared.Car;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CarServiceCenter.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IEntityRepo<Car> _carRepo;
        
        public CarController(IEntityRepo<Car> carRepo)
        {
            _carRepo = carRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CarListDto>> Get()
        {
            var result = _carRepo.GetAll();
            return result.Select(Car => new CarListDto
            {   
                Id = Car.Id,
                Model = Car.Model,
                Brand = Car.Brand,
                CarRegistrationNumber = Car.CarRegistrationNumber
            });
        }

        [HttpGet("{id}")]
        public async Task<CarEditDto> GetById(int id)
        {
            var result = _carRepo.GetById(id);
            return new CarEditDto
            {
                Id = id,
                Model = result.Model,
                Brand = result.Brand,
                CarRegistrationNumber = result.CarRegistrationNumber
            };
        }

        [HttpPost]
        public async Task Post(CarEditDto car)
        {
            var newCar = new Car(car.Brand, car.Model, car.CarRegistrationNumber);
            _carRepo.Add(newCar);
        }

        [HttpPut]
        public async Task Put(CarEditDto car)
        {
            var carToUpdate = _carRepo.GetById(car.Id);
            carToUpdate.Model = car.Model;
            carToUpdate.Brand = car.Brand;
            carToUpdate.CarRegistrationNumber = car.CarRegistrationNumber;
            _carRepo.Update(car.Id, carToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _carRepo.Delete(id);
        }

    }
}
