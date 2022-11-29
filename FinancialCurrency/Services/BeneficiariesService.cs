using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public class BeneficiariesService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
