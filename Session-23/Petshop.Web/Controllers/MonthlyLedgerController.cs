using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Petshop.Web.Controllers
{
    public class MonthlyLedgerController : Controller
    {
        // GET: MonthlyLedgerController
        public ActionResult Index()
        {
            return View();
        }

    }
}
