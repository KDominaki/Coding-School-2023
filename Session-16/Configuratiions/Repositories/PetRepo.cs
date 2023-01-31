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
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
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
        }
    }
}
