using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CarServiceCenter.EF.Repositories
{
    public class CarRepo : IEntityRepo<Car>
    {
        public void Add(Car entity)
        {
            using var context = new CarServiceCenterDbContext();
            if (entity.Id != 0)
            { 
                throw new ArgumentException("Given entity should not have Id set", nameof(entity)); 
            }
           context.Cars.Add(entity);
           context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new CarServiceCenterDbContext();
            var dbCar = context.Cars.SingleOrDefault(car => car.Id == id);
            if (dbCar is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Cars.Remove(dbCar);
            context.SaveChanges();
        }

        public IList<Car> GetAll()
        {
          using var context = new CarServiceCenterDbContext();
          return context.Cars.ToList();
        }

        public Car? GetById(int id)
        {
           using var context = new CarServiceCenterDbContext();
            return context.Cars.SingleOrDefault(car => car.Id == id);
        }

        public void Update(int id, Car entity)
        {
            using var context = new CarServiceCenterDbContext(); 
            var dbCar = context.Cars.SingleOrDefault(car => car.Id ==id);
            if (dbCar is null )
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbCar.CarRegistrationNumber = entity.CarRegistrationNumber;
            dbCar.Brand = entity.Brand;
            dbCar.Model = entity.Model;
            context.SaveChanges();
        }
    }
}
