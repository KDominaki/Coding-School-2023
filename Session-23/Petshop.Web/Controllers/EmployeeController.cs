using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repos;
using PetShop.Model;

namespace Petshop.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var employee = _employeeRepo.GetAll();
            return View(model : employee);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreateDto employee)
        {
            if (!ModelState.IsValid) { return View(); }
            var dbEmployee = new Employee(employee.Name, employee.Surname, employee.EmployeeType, employee.SalaryPerMonth);
            _employeeRepo.Add(dbEmployee);
            return RedirectToAction("Index");
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null)
            {
                return NotFound();
            }

            var viewEmployee = new EmployeeEditDto
            {
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname,
                SalaryPerMonth = dbEmployee.SalaryPerMonth,
                EmployeeType = dbEmployee.EmployeeType,
                Id = dbEmployee.Id
            };


            return View(model: viewEmployee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeEditDto employee)
        {
            if (!ModelState.IsValid) { return View(); }
            var dbEmployee = _employeeRepo.GetById(id);

            if (dbEmployee == null)
            {
                return NotFound();
            }
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            dbEmployee.EmployeeType = employee.EmployeeType;
            dbEmployee.Id = employee.Id;

            _employeeRepo.Update(id, dbEmployee);
            return RedirectToAction(nameof(Index));
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
