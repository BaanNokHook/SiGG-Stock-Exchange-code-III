using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public class DirectDebitService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
