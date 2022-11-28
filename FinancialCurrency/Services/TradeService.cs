using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public class TradeService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
