using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public class EndusersService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
