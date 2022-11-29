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
    public class ComplianceController : Controller
    {
        private readonly IComplianceService ComplianceService;

        public ComplianceController(IComplianceService ComplianceService)
        {
            this.ComplianceService = ComplianceService;
        }

        [HttpPost(ApiRoutes.Compliance.StateI)]  
        public IActionResult PostStateI([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = ComplianceService.PostStateI(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Compliance.StateI)]  
        public IActionResult GetStateI([FromRoute] string Accept, string Authorization)
        {
            var response = ComplianceService.GetStateI(Accept, Authorization);

            return Ok(Response);  
        }

        [HttpPost(ApiRoutes.Compliance.StateII)]  
        public IActionResult PostStateII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = ComplianceService.PostStateII(ContentType, Accept, Authorization, Body);

            return Ok(Response);  
        }

        [HttpGet(ApiRoutes.Compliance.StateII)]  
        public IActionResult GetStateII([FromRoute] string Accept, string Authorization)
        {
            var response = ComplianceService.GetStateII(Accept, Authorization);

            return Ok(Response);  
        }

        [HttpPost(ApiRoutes.Compliance.StateIII)]  
        public IActionResult PostStateIII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = ComplianceService.PostStateIII(ContentType, Accept, Authorization, Body);

            return Ok(Response);  
        }

        [HttpGet(ApiRoutes.Compliance.StateIII)]  
        public IActionResult GetStateIII([FromRoute] string Accept, string Authorization)
        {
            var response = ComplianceService.GetStateIII(Accept, Authorization);

            return Ok(Response);   
        }

        [HttpPost(ApiRoutes.Compliance.StateIV)]   
        public IActionResult PostStateIV([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = ComplianceService.PostStateIV(ContentType, Accept, Authorization, Body);

            return Ok(Response);  
        }

        [HttpGet(ApiRoutes.Compliance.StateIV)]  
        public IActionResult GetStateIV([FromRoute] string Accept, string Authorization)
        {
            var response = ComplianceService.GetStateIV(Accept, Authorization);

            return Ok(Response);  
        }

        [HttpGet(ApiRoutes.Compliance.StateV)]  
        public IActionResult GetStateV([FromRoute] string Accept, string Authorization)
        {
            var response = ComplianceService.GetStateV(Accept, Authorization);

            return Ok(Response);  
        }

        [HttpGet(ApiRoutes.Compliance.StateVI)]  
        public IActionResult GetStateVI([FromRoute] string Accept, string Authorization)
        {
            var response = ComplianceService.GetStateVI(Accept, Authorization);

            return Ok(Response);  
        }

        [HttpGet(ApiRoutes.Compliance.StateVII)]   
        public IActionResult GetStateVII([FromRoute] string Accept, string Authorization)
        {
            var response = ComplianceService.GetStateVII(Accept, Authorization);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Compliance.StateVIII)]  
        public IActionResult PostStateVIII([FromRoute] string ContentType, string Accept, string Authorization)
        {
            var response = ComplianceService.PostStateVIII(ContentType, Accept, Authorization);

            return Ok(Response);  
        }

        [HttpPost(ApiRoutes.Compliance.StateIX)]  
        public IActionResult PostStateIX([FromRoute] string ContentType, string Accept, string Authorization)
        {
            var response = ComplianceService.PostStateIX(ContentType, Accept, Authorization);

            return Ok(Response);   
        }

        [HttpPost(ApiRoutes.Compliance.StateX)]
        public IActionResult PostStateX([FromRoute] string ContentType, string Accept, string Authorization)
        {
            var response = ComplianceService.PostStateX(ContentType, Accept, Authorization);

            return Ok(Response);  
        }

        [HttpPost(ApiRoutes.Compliance.StateXI)]  
        public IActionResult PostStateXI([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = ComplianceService.PostStateXI(ContentType, Accept, Authorization, Body);

            return Ok(Response);  
        }

        [HttpPost(ApiRoutes.Compliance.StateXII)]
        public IActionResult PostStateXII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = ComplianceService.PostStateXII(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Compliance.StateXIII)]
        public IActionResult PostStateXIII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = ComplianceService.PostStateXIII(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Compliance.StateXIV)]
        public IActionResult PostStateXIV([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = ComplianceService.PostStateXIV(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Compliance.StateXV)]
        public IActionResult GetStateXV([FromRoute] string Accept, string Authorization, string dataset_id)
        {
            var response = ComplianceService.GetStateXV(Accept, Authorization, dataset_id);

            return Ok(Response);  
        }

        [HttpGet(ApiRoutes.Compliance.StateXVI)]  
        public IActionResult GetStateXVI([FromRoute] string Accept, string Authorization)
        {
            var response = ComplianceService.GetStateXVI(Accept, Authorization);

            return Ok(Response);  
        }
    }
}




   