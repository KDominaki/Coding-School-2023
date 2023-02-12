using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repos;
using PetShop.Model;
using System.Data.Common;

namespace Petshop.Web.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        // GET: TransactionController
        public ActionResult Index()
        {
            var transactions = _transactionRepo.GetAll();
            return View(model : transactions);
        }

        // GET: TransactionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransactionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transaction)
        {
            if (!ModelState.IsValid) { return View(); }
            var dbTransaction = new Transaction(transaction.PetPrice, transaction.PetFoodQty, transaction.PetFoodPrice)
            {
                CustomerId= transaction.CustomerId,
                EmployeeId= transaction.EmployeeId,
                PetFoodId= transaction.PetFoodId,
                PetId = transaction.PetId,
            };
            _transactionRepo.Add(dbTransaction);
            return RedirectToAction("Index");
        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null)
            {
                return NotFound();
            }

            var viewCustomer = new TransactionEditDto
            {
                PetPrice = dbTransaction.PetPrice,
                PetFoodQty = dbTransaction.PetFoodQty,
                PetFoodPrice = dbTransaction.PetFoodPrice,
                PetId = dbTransaction.PetId,
                PetFoodId= dbTransaction.PetFoodId,
                CustomerId = dbTransaction.CustomerId,
                EmployeeId = dbTransaction.EmployeeId,
                Id = dbTransaction.Id
            };


            return View(model: viewCustomer);
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionEditDto transaction)
        {
            if (!ModelState.IsValid) { return View(); }
            var dbTransaction = _transactionRepo.GetById(id);

            if (dbTransaction == null)
            {
                return NotFound();
            }
            dbTransaction.PetPrice = dbTransaction.PetPrice;
            dbTransaction.PetFoodQty = dbTransaction.PetFoodQty;
            dbTransaction.PetFoodPrice = dbTransaction.PetFoodPrice;
            dbTransaction.PetId = dbTransaction.PetId;
            dbTransaction.PetFoodId = dbTransaction.PetFoodId;
            dbTransaction.CustomerId = dbTransaction.CustomerId;
            dbTransaction.EmployeeId = dbTransaction.EmployeeId;
            dbTransaction.Id = transaction.Id;

            _transactionRepo.Update(id, dbTransaction);
            return RedirectToAction(nameof(Index));
        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id)
        {
            if (!ModelState.IsValid) { return View(); }
            var dbTransaction = _transactionRepo.GetById(id);

            if (dbTransaction == null)
            {
                return NotFound();
            }

            var viewTransaction = new TransactionDeleteDto
            {
                PetPrice = dbTransaction.PetPrice,
                PetFoodQty = dbTransaction.PetFoodQty,
                PetFoodPrice = dbTransaction.PetFoodPrice,
                PetId = dbTransaction.PetId,
                PetFoodId = dbTransaction.PetFoodId,
                CustomerId = dbTransaction.CustomerId,
                EmployeeId = dbTransaction.EmployeeId,
                Id = dbTransaction.Id
            };

            return View(model: viewTransaction);
        

        }

    // POST: TransactionController/Delete/5
    [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _transactionRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }

}
