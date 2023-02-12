using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repos;
using PetShop.Model;

namespace Petshop.Web.Controllers
{
    public class PetFoodController : Controller
    {
        private readonly IEntityRepo<PetFood> _petFoodRepo;
        public PetFoodController(IEntityRepo<PetFood> petFoodRepo)
        {
            _petFoodRepo = petFoodRepo;
        }
        // GET: PetFoodController
        public ActionResult Index()
        {
            var petFoods = _petFoodRepo.GetAll();
            return View(model : petFoods);
        }

        // GET: PetFoodController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PetFoodController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetFoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetFoodCreateDto petFood)
        {
            if (!ModelState.IsValid) { return View(); }
            var dbPetFood = new PetFood(petFood.AnimalType, petFood.Price, petFood.Cost);
            _petFoodRepo.Add(dbPetFood);
            return RedirectToAction("Index");
        }

        // GET: PetFoodController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbPetFood = _petFoodRepo.GetById(id);
            if (dbPetFood == null)
            {
                return NotFound();
            }

            var viewPetFood = new PetFoodEditDto
            {
                AnimalType = dbPetFood.AnimalType,
                Price = dbPetFood.Price,
                Cost = dbPetFood.Cost,
                Id = dbPetFood.Id
            };


            return View(model: viewPetFood);
        }

        // POST: PetFoodController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetFoodEditDto petFood)
        {
            if (!ModelState.IsValid) { return View(); }
            var dbPetFood = _petFoodRepo.GetById(id);

            if (dbPetFood == null)
            {
                return NotFound();
            }
            dbPetFood.AnimalType = dbPetFood.AnimalType;
            dbPetFood.Price = dbPetFood.Price;
            dbPetFood.Cost = dbPetFood.Cost;
            dbPetFood.Id = petFood.Id;

            _petFoodRepo.Update(id, dbPetFood);
            return RedirectToAction(nameof(Index));
        }

        // GET: PetFoodController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetFoodController/Delete/5
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
