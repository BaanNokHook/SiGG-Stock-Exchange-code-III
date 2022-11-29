using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public class QuarantineService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
