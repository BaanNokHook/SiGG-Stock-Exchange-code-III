using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public class CardsService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
