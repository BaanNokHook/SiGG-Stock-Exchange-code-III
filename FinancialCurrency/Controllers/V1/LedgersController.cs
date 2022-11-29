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
    public class LedgersController : Controller
    {
        private readonly ILedgersService LedgersService;

        public LedgersController(ILedgersService LedgersService)
        {
            this.LedgersService = LedgersService;
        }

        [HttpGet(ApiRoutes.Ledgers.StateI)]
        public IActionResult GetStateI([FromRoute] string Accept, string Authorization)
        {
            var response = LedgersService.GetStateI(Accept, Authorization);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Ledgers.StateI)]
        public IActionResult PostStateI([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = LedgersService.PostStateI(ContentType, Accept, Authorization, Body);

            return Ok(Response);   
        }

        [HttpGet(ApiRoutes.Ledgers.StateII)]
        public IActionResult GetStateII([FromRoute] string iban, string Accept, string Authorization)
        {
            var response = LedgersService.GetStateII(iban, Accept, Authorization);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Ledgers.StateIII)]
        public IActionResult GetStateIII([FromRoute] string uk_account_number, string uk_sort_code, string Accept, string Authorization)
        {
            var response = LedgersService.GetStateIII(uk_account_number, uk_sort_code, Accept, Authorization);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Ledgers.StateIV)]
        public IActionResult GetStateIV([FromRoute] string Accept, string Authorization)
        {
            var response = LedgersService.GetStateIV(Accept, Authorization);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Ledgers.StateV)]
        public IActionResult GetStateV([FromRoute] string Accept, string Authorization)
        {
            var response = LedgersService.GetStateV(Accept, Authorization);

            return Ok(Response);
        }


        [HttpPost(ApiRoutes.Ledgers.StateVI)]
        public IActionResult PostStateVI([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = LedgersService.PostStateVI(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Ledgers.StateVII)]
        public IActionResult GetStateV([FromRoute] string Accept, string Authorization, string ledger_id)
        {
            var response = LedgersService.GetStateVII(Accept, Authorization, ledger_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Ledgers.StateVIII)]
        public IActionResult PostStateVIII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = LedgersService.PostStateVIII(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Ledgers.StateIX)]
        public IActionResult PostStateIX([FromRoute] string ContentType, string Accept, string Authorization, string ledger1_id)
        {
            var response = LedgersService.PostStateIX(ContentType, Accept, Authorization, ledger1_id);

            return Ok(Response);
        }
        
        [HttpPost(ApiRoutes.Ledgers.StateX)]
        public IActionResult PostStateX([FromRoute] string ContentType, string Accept, string Authorization, string ledger1_id)
        {
            var response = LedgersService.PostStateX(ContentType, Accept, Authorization, ledger1_id);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Ledgers.StateXI)]
        public IActionResult GetStateXI([FromRoute] string ledger_id, string Accept, string Authorization, string ledger1_id)
        {
            var response = LedgersService.GetStateXI(ledger_id, Accept, Authorization, ledger1_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Ledgers.StateXII)]
        public IActionResult PostStateXII([FromRoute] string ContentType, string Accept, string Authorization, string ledger1_id)
        {
            var response = LedgersService.PostStateXII(ContentType, Accept, Authorization, ledger1_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Ledgers.StateXIII)]
        public IActionResult PostStateXIII([FromRoute] string ContentType, string Accept, string Authorization, string ledger1_id)
        {
            var response = LedgersService.PostStateXIII(ContentType, Accept, Authorization, ledger1_id);

            return Ok(Response);
        }

    }
}