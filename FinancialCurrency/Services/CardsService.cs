using FinancialCurrency.API.ViewModels;
using FinancialCurrency.Domain;
using Microsoft.AspNetCore.Mvc;
using System;

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



