using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public class LedgersService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
