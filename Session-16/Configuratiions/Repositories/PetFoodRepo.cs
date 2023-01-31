using ClassLibrary1;
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
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbPetFood = context.Petfoods.Where(petfood => petfood.ID == id).SingleOrDefault();
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
            using var context = new AppDbContext();
            return context.Petfoods.ToList();
        }

        public PetFood? GetById(Guid id)
        {
            using var context = new AppDbContext();
            return context.Petfoods.Where(petfood => petfood.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, PetFood entity)
        {
            using var context = new AppDbContext();
            var dbPetFood = context.Petfoods.Where(petfood => petfood.ID == id).SingleOrDefault();
            if (dbPetFood is null)
            {
                return;
            }
            else
            {
                dbPetFood.Qty= entity.Qty;
                dbPetFood.Price= entity.Price;
                dbPetFood.Cost = entity.Cost;
                dbPetFood.Animaltype= entity.Animaltype;
                dbPetFood.PetFoodTransactions= entity.PetFoodTransactions;
                context.SaveChanges();
            }
        }
    }
}
