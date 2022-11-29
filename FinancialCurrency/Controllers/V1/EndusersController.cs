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
    public class EndusersController : Controller
    {
        private readonly IEndusersService EndusersService;

        public EndusersController(IEndusersService EndusersService)
        {
            this.EndusersService = EndusersService;
        }

        [HttpGet(ApiRoutes.Endusers.StateI)]  
        public IActionResult GetStateI([FromRoute] string Accept, string Authorization)
        {
            var response = EndusersService.GetStateI(Accept, Authorization);

            return Ok(Response);  
        }


        [HttpPost(ApiRoutes.Endusers.StateI)]
        public IActionResult PostStateI([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = EndusersService.PostStateI(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Endusers.StateII)]
        public IActionResult GetStateII([FromRoute] string Accept, string Authorization, string enduser_id)
        {
            var response = EndusersService.GetStateII(Accept, Authorization, enduser_id);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Endusers.StateIII)]
        public IActionResult GetStateIII([FromRoute] string Accept, string Authorization, string enduser_id)
        {
            var response = EndusersService.GetStateIII(Accept, Authorization, enduser_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Endusers.StateIV)]
        public IActionResult PostStateIV([FromRoute] string ContentType, string Accept, string Authorization, string enduser_id)
        {
            var response = EndusersService.PostStateIV(ContentType, Accept, Authorization, enduser_id);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Endusers.StateV)]
        public IActionResult GetStateV([FromRoute] string Accept, string Authorization, string enduser_id)
        {
            var response = EndusersService.GetStateV(Accept, Authorization, enduser_id);

            return Ok(Response);
        }

    }
}
