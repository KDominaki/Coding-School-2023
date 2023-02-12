using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repos;
using PetShop.Model;

namespace Petshop.Web.Controllers
{
    public class PetController : Controller
    {
        private readonly IEntityRepo<Pet> _petRepo;
        public PetController(IEntityRepo<Pet> petRepo)
        {
            _petRepo = petRepo;
        }
        // GET: PetController
        public ActionResult Index()
        {
            var pets = _petRepo.GetAll();
            return View(model: pets);
        }

        // GET: PetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetCreateDto pet)
        {
            if (!ModelState.IsValid) { return View(); }
            var dbPet = new Pet(pet.Breed, pet.AnimalType, pet.PetStatus, pet.Price, pet.Cost);
            _petRepo.Add(dbPet);
            return RedirectToAction("Index");
        }

        // GET: PetController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbPet = _petRepo.GetById(id);
            if (dbPet == null)
            {
                return NotFound();
            }

            var viewPet = new PetEditDto
            {
                Breed = dbPet.Breed,
                Price= dbPet.Price,
                PetStatus = dbPet.PetStatus,
                AnimalType = dbPet.AnimalType,
                Id = dbPet.Id
            };


            return View(model: viewPet);
        }

        // POST: PetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetEditDto pet)
        {
            if (!ModelState.IsValid) { return View(); }
            var dbPet = _petRepo.GetById(id);

            if (dbPet == null)
            {
                return NotFound();
            }
            dbPet.Breed = dbPet.Breed;
            dbPet.Price = dbPet.Price;
            dbPet.PetStatus = dbPet.PetStatus;
            dbPet.AnimalType = dbPet.AnimalType;
            dbPet.Id = pet.Id;

            _petRepo.Update(id, dbPet);
            return RedirectToAction(nameof(Index));
        }

        // GET: PetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetController/Delete/5
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
