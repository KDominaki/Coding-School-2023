
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
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
            if (dbEmployee is null)
            {
                return;
            }
            else
            {
                context.Remove(dbEmployee);
                context.SaveChanges();
            }
        }

        public IList<Employee> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Employees.Where(employee => employee.Id== id).SingleOrDefault();
        }

        public void Update(int id, Employee entity)
        {
            using var context = new PetShopDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
            if (dbEmployee is null)
            {
                return;
            }
            else
            {
                dbEmployee.Name = entity.Name;
                dbEmployee.Surname = entity.Surname;
                dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;
                dbEmployee.EmployeeType = entity.EmployeeType;
                context.SaveChanges();
            }
        }
    }
}
