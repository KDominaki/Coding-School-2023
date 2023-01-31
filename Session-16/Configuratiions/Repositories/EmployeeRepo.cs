using ClassLibrary1;
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
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
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
            using var context = new AppDbContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(Guid id)
        {
            using var context = new AppDbContext();
            return context.Employees.Where(employee => employee.ID== id).SingleOrDefault();
        }

        public void Update(Guid id, Employee entity)
        {
            using var context = new AppDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
            if (dbEmployee is null)
            {
                return;
            }
            else
            {
                dbEmployee.Name = entity.Name;
                dbEmployee.Surname = entity.Surname;
                dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;
                dbEmployee.EmpType = entity.EmpType;
                context.SaveChanges();
            }
        }
    }
}
