using FinancialCurrency.API.Infrastructure;
using FinancialCurrency.API.Services;
using FinancialCurrency.API.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Controllers.V1
{

    //[Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class CardsController : Controller
    {
        private readonly ICardsService CardsService;

        public CardsController(ICardsService CardsService)
        {
            //this.config = config  
            this.CardsService = CardsService;
        }

        [HttpPost(ApiRoutes.Cards.StateI)]
        public IActionResult PostStateI([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = CardsService.PostStateI(ContentType, Accept, Authorization, Body);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Cards.StateI)]
        public IActionResult GetStateI([FromRoute] string Accept, string Authorization)
        {
            var response = CardsService.GetStateI(Accept, Authorization);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Cards.StateII)]  
        public IActionResult GetStateII([FromRoute] string Accept, string Authorization, string card_token)
        {
            var response = CardsService.GetStateII(Accept, Authorization, card_token);

            return Ok(response);  
        }

        [HttpPost(ApiRoutes.Cards.StateIII)]  
        public IActionResult PostStateIII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = CardsService.PostStateIII(ContentType, Accept, Authorization, Body);

            return Ok(response);  
        }

        [HttpGet(ApiRoutes.Cards.StateIII)]
        public IActionResult GetStateIII([FromRoute] string Accept, string Authorization)
        {
            var response = CardsService.GetStateIII(Accept, Authorization);

            return Ok(response);

        }

        [HttpGet(ApiRoutes.Cards.StateIV)]
        
        public IActionResult GetStateIV([FromRoute] string Accept, string Authorization, string card_rule_1)
            {
            var response = CardsService.GetStateIV(Accept, Authorization, card_rule_1);

            return Ok(response);
        }

        [HttpPut(ApiRoutes.Cards.StateIV)]

        public IActionResult PutStateIV([FromRoute] string Accept, string Authorization, string card_rule_1)
        {
            var response = CardsService.GetStateIV(Accept, Authorization, card_rule_1);

            return Ok(response);
        }

        [HttpPost(ApiRoutes.Cards.StateV)]  
        public IActionResult PostStateV([FromRoute] string ContentType, string Accept, string Authorization, string card_rule_1)
        {
            var response = CardsService.PostStateV(ContentType, Accept, Authorization, card_rule_1);

            return Ok(response);
        }
    }
}
