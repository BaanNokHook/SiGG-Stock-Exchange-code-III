using FinancialCurrency.API.Infrastructure;
using FinancialCurrency.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace FinancialCurrency.API.Controllers.V1
{
    //[Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class TradeController : ControllerBase
    {
        private readonly ITradeService TradeService;  

        public TradeController(ITradeService TradeService)
        {
            //this.config = config  
            this.TradeService = TradeService;  
        }

        [HttpGet(ApiRoutes.Trade.Openport)]
        public IActionResult Openport([FromRoute] long API_Key)
        {
            var response = TradeService.GetOpenport(API_Key);

            return Ok(response);  
        }

        [HttpGet(ApiRoutes.Trade.Brokers)]  
        public IActionResult Brokers([FromRoute] long tradesId, long transactionId)
        {
            var response = TradeService.GetBrokers(tradesId, transactionId);

            return Ok(response);
        }

    }

}



