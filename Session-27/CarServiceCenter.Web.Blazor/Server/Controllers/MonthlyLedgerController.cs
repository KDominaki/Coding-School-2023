using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Blazor.Server.Controllers
{
    public class MonthlyLedgerController : Controller
    {
        public IActionResult Get()
        {
            return View();
        }
    }
}
