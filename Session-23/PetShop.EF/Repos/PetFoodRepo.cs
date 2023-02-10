
using PetShop.EF.Context;
using PetShop.EF.Repos;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationsLibrary.Repositories
{
    public class PetFoodRepo : IEntityRepo<PetFood>
    {
        public void Add(PetFood entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.Where(petfood => petfood.Id == id).SingleOrDefault();
            if (dbPetFood is null)
            {
                return;
            }
            else
            {
                context.Remove(dbPetFood);
                context.SaveChanges();
            }
        }

        public IList<PetFood> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.PetFoods.ToList();
        }

        public PetFood? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.PetFoods.Where(petfood => petfood.Id == id).SingleOrDefault();
        }

        public void Update(int id, PetFood entity)
        {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.Where(petfood => petfood.Id == id).SingleOrDefault();
            if (dbPetFood is null)
            {
                return;
            }
            else
            {
                dbPetFood.Price= entity.Price;
                dbPetFood.Cost = entity.Cost;
                dbPetFood.AnimalType= entity.AnimalType;
                dbPetFood.Transactions= entity.Transactions;
                context.SaveChanges();
            }
        }
    }
}
