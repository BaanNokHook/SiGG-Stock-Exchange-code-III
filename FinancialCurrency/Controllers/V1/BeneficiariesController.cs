using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Controllers.V1
{
    public class BeneficiariesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
