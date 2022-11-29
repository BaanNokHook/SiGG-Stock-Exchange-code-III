using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public class WebhookService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
