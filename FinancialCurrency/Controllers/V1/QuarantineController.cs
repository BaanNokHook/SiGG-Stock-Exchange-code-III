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
    public class QuarantineController : Controller
    {
        private readonly IQuarantineService QuarantineService;

        public QuarantineController(IQuarantineService QuarantineService)
        {
            this.QuarantineService = QuarantineService;
        }

        [HttpGet(ApiRoutes.Quarantine.StateI)]
        public IActionResult GetStateI([FromRoute] string Accept, string Authorization)
        {
            var response = QuarantineService.GetStateI(Accept, Authorization);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Quarantine.StateII)]
        public IActionResult GetStateII([FromRoute] string Accept, string Authorization)
        {
            var response = QuarantineService.GetStateII(Accept, Authorization);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Quarantine.StateIII)]
        public IActionResult GetStateIII([FromRoute] string Accept, string Authorization, string beneficiary_id)
        {
            var response = QuarantineService.GetStateIII(Accept, Authorization, beneficiary_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Quarantine.StateIV)]
        public IActionResult PostStateIV([FromRoute] string ContentType, string Accept, string Authorization, string Body, string beneficiary_id)
        {
            var response = QuarantineService.PostStateIV(ContentType, Accept, Authorization, Body, beneficiary_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Quarantine.StateV)]
        public IActionResult PostStateV([FromRoute] string ContentType, string Accept, string Authorization, string Body, string beneficiary_id)
        {
            var response = QuarantineService.PostStateV(ContentType, Accept, Authorization, Body, beneficiary_id);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Quarantine.StateVI)]
        public IActionResult GetStateVI([FromRoute] string Accept, string Authorization)
        {
            var response = QuarantineService.GetStateVI(Accept, Authorization);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Quarantine.StateVII)]
        public IActionResult GetStateVII([FromRoute] string Accept, string Authorization, string enduser_id)
        {
            var response = QuarantineService.GetStateVII(Accept, Authorization, enduser_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Quarantine.StateVIII)]
        public IActionResult PostStateVIII([FromRoute] string ContentType, string Accept, string Authorization, string Body, string enduser_id)
        {
            var response = QuarantineService.PostStateVIII(ContentType, Accept, Authorization, Body, enduser_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Quarantine.StateIX)]
        public IActionResult PostStateIX([FromRoute] string ContentType, string Accept, string Authorization, string Body, string enduser_id)
        {
            var response = QuarantineService.PostStateIX(ContentType, Accept, Authorization, Body, enduser_id);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Quarantine.StateX)]
        public IActionResult GetStateX([FromRoute] string Accept, string Authorization)
        {
            var response = QuarantineService.GetStateX(Accept, Authorization);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Quarantine.StateXI)]
        public IActionResult GetStateXI([FromRoute] string Accept, string Authorization, string transaction_id)
        {
            var response = QuarantineService.GetStateXI(Accept, Authorization, transaction_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Quarantine.StateXII)]
        public IActionResult PostStateXII([FromRoute] string ContentType, string Accept, string Authorization, string Body, string transaction_id)
        {
            var response = QuarantineService.PostStateXII(ContentType, Accept, Authorization, Body, transaction_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Quarantine.StateXIII)]
        public IActionResult PostStateXIII([FromRoute] string ContentType, string Accept, string Authorization, string Body, string transaction_id)
        {
            var response = QuarantineService.PostStateXIII(ContentType, Accept, Authorization, Body, transaction_id);

            return Ok(Response);
        }

    }
}

