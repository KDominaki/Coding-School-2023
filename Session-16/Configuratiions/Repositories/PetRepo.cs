using ClassLibrary1;
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
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbPet = context.Pets.Where(pet => pet.ID == id).SingleOrDefault();
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
            using var context = new AppDbContext();
            return context.Pets.ToList();
        }

        public Pet? GetById(Guid id)
        {
            using var context = new AppDbContext();
            return context.Pets.Where(pet => pet.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, Pet entity)
        {
            using var context = new AppDbContext();
            var dbPet = context.Pets.Where(pet => pet.ID == id).SingleOrDefault();
            if (dbPet is null)
            {
                return;
            }
            else
            {
                dbPet.Breed = entity.Breed;
                dbPet.Petstatus = entity.Petstatus;
                dbPet.Cost = entity.Cost;
                dbPet.Bought = entity.Bought;
                dbPet.Sold= entity.Sold;
                dbPet.Animaltype= entity.Animaltype;
                dbPet.Price= entity.Price;
                context.SaveChanges();
            }
        }
    }
}
