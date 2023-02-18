using Session30.EF.Context;
using Session30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.EF.Repositories
{
    public class ItemRepo : IEntityRepo<Item>
    {
        public void Add(Item entity)
        {
            using var context = new AppDbContext();
            if (entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Items.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbItem = context.Items.SingleOrDefault(Item => Item.Id == id);
            if (dbItem is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Items.Remove(dbItem);
            context.SaveChanges();
        }

        public IList<Item> GetAll()
        {
            using var context = new AppDbContext();
            return context.Items.ToList();
        }

        public Item? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Items.SingleOrDefault(Item => Item.Id == id);
        }

        public void Update(int id, Item entity)
        {
            using var context = new AppDbContext();
            var dbItem = context.Items.SingleOrDefault(Item => Item.Id == id);
            if (dbItem is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbItem.Code = entity.Code;
            dbItem.Description = entity.Description;
            dbItem.ItemType = entity.ItemType;
            dbItem.Price = entity.Price;
            dbItem.Cost = entity.Cost;

            context.SaveChanges();
        }
    }
}
