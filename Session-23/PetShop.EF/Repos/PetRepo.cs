
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
    public class PetRepo : IEntityRepo<Pet>
    {
        public void Add(Pet entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.Where(pet => pet.Id == id).SingleOrDefault();
            if (dbPet is null)
            {
                return;
            }
            else
            {
                context.Remove(dbPet);
                context.SaveChanges();
            }
        }

        public IList<Pet> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Pets.ToList();
        }

        public Pet? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Pets.Where(pet => pet.Id == id).SingleOrDefault();
        }

        public void Update(int id, Pet entity)
        {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.Where(pet => pet.Id == id).SingleOrDefault();
            if (dbPet is null)
            {
                return;
            }
            else
            {
                dbPet.Breed = entity.Breed;
                dbPet.PetStatus = entity.PetStatus;
                dbPet.Cost = entity.Cost;
                dbPet.AnimalType= entity.AnimalType;
                dbPet.Price= entity.Price;
                dbPet.Transactions = entity.Transactions;
                context.SaveChanges();
            }
        }
    }
}
