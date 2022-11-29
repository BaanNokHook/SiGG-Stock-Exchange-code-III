using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public class TransactionServicecs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
