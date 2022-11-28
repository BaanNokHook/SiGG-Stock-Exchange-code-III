using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialCurrency.API.Infrastructure;
using FinancialCurrency.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FinancialCurrency.API.Controllers.V1
{
    //[Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService BankService;

        public BankController(IBankService BankService)
        {
            //this.config = config;
            this.BankService = BankService;
        }

        [HttpPost(ApiRoutes.Bank.BankInfo)]
        public IActionResult BankInfo([FromRoute] long userId)
        {
            var response = BankService.GetBankInfo(userId);

            return Ok(response);
        }

        [HttpPost(ApiRoutes.Bank.BankDeposit)]
        public IActionResult Deposit([FromRoute] long userId, decimal amount)
        {
            var response = BankService.Deposit(userId, amount);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Bank.BankWithdraw)]
        public IActionResult Withdraw([FromRoute] long userId, decimal amount)
        {
            var response = BankService.Withdraw(userId, amount);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Bank.BankConvert)]
        public IActionResult ConvertToCurruncy([FromRoute] long userId, string targetCurrency)
        {
            var response = BankService.ConvertToCurrency(userId, targetCurrency.ToUpper());

            return Ok(response);
        }
    }
}




