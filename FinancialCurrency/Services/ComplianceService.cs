using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public class ComplianceService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
