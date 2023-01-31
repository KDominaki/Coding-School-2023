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
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
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
        }
    }
}
