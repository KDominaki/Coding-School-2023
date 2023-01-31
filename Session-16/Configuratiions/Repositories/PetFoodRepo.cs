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
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
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
        }
    }
}
