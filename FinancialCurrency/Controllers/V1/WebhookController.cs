using FinancialCurrency.API.Controllers.V1;
using FinancialCurrency.API.Infrastructure;
using FinancialCurrency.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FinancialCurrency.API.Controllers.V1
{

    //[Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class WebhookController : Controller
    {
        private readonly IWebhookService WebhookService;

        public WebhookController(IWebhookService WebhookService)
        {
            this.WebhookService = WebhookService;
        }

        [HttpPost(ApiRoutes.Webhook.StateI)]  
        public IActionResult PostStateI([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = WebhookService.PostStateI(ContentType, Accept, Authorization, Body);

            return Ok(Response);   

        }

        [HttpDelete(ApiRoutes.Webhook.StateI)]  
        public IActionResult DeleteStateI([FromRoute] string Accept, string Authorization)
        {
            var response = WebhookService.DeleteStateI(Accept, Authorization);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Webhook.StateI)]
        public IActionResult GetStateI([FromRoute] string Accept, string Authorization)
        {
            var response = WebhookService.GetStateI(Accept, Authorization);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Webhook.StateII)]
        public IActionResult GetStateII([FromRoute] string Accept, string Authorization)
        {
            var response = WebhookService.GetStateII(Accept, Authorization);

            return Ok(Response);
        }


        [HttpPost(ApiRoutes.Webhook.StateIII)]
        public IActionResult PostStateIII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = WebhookService.PostStateIII(ContentType, Accept, Authorization, Body);

            return Ok(Response);

        }
    }
}

      