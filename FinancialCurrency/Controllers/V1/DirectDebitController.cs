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
    public class DirectDebitController : Controller
    {
        private readonly IDirectDebitService DirectDebitService;

        public DirectDebitController(IDirectDebitService DirectDebitService)
        {
            this.DirectDebitService = DirectDebitService;
        }

        [HttpPost(ApiRoutes.DirectDebit.StateI)]
        public IActionResult PostStateI([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = DirectDebitService.PostStateI(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.DirectDebit.StateI)]  
        public IActionResult GetStateI([FromRoute] string Accept, string Authorization)
        {
            var response = DirectDebitService.GetStateI(Accept, Authorization);

            return Ok(Response);   
        }

        [HttpGet(ApiRoutes.DirectDebit.StateII)]   
        public IActionResult GetStateII([FromRoute] string Accept, string Authorization, string mandate_id)
        {
            var response = DirectDebitService.GetStateII(Accept, Authorization, mandate_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.DirectDebit.StateIII)]   
        public IActionResult PostStateIII([FromRoute] string ContentType, string Accept, string Authorization, string mandate_id)
        {
            var response = DirectDebitService.PostStateIII(ContentType, Accept, Authorization, mandate_id);

            return Ok(Response);    
        }

        [HttpPost(ApiRoutes.DirectDebit.StateIV)]
        public IActionResult PostStateIV([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = DirectDebitService.PostStateIV(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.DirectDebit.StateIV)]
        public IActionResult GetStateIV([FromRoute] string Accept, string Authorization)
        {
            var response = DirectDebitService.GetStateIV(Accept, Authorization);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.DirectDebit.StateV)]
        public IActionResult GetStateV([FromRoute] string Accept, string Authorization, string payment_id)
        {
            var response = DirectDebitService.GetStateV(Accept, Authorization, payment_id);

            return Ok(Response);
        }

    }
}
