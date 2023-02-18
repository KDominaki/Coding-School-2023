using Session30.EF.Context;
using Session30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var context = new AppDbContext();
            if (entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Employees.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbEmployee = context.Employees.SingleOrDefault(Employee => Employee.Id == id);
            if (dbEmployee is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Employees.Remove(dbEmployee);
            context.SaveChanges();
        }

        public IList<Employee> GetAll()
        {
            using var context = new AppDbContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Employees.SingleOrDefault(Employee => Employee.Id == id);
        }

        public void Update(int id, Employee entity)
        {
            using var context = new AppDbContext();
            var dbEmployee = context.Employees.SingleOrDefault(Employee => Employee.Id == id);
            if (dbEmployee is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbEmployee.Surname = entity.Surname;
            dbEmployee.Name = entity.Name;
            dbEmployee.HireDateStart = entity.HireDateStart;
            dbEmployee.HireDateEnd = entity.HireDateEnd;
            dbEmployee.SallaryPerMonth = entity.SallaryPerMonth;
            dbEmployee.EmployeeType = entity.EmployeeType;

            context.SaveChanges();
        }
    }
}
