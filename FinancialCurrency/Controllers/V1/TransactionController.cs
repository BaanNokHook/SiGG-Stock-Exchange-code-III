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
    public class TransactionController : Controller
    {
        private readonly ITransactionService TransactionService;

        public TransactionController(ITransactionService TransactionService)
        {
            this.TransactionService = TransactionService;
        }


        [HttpPost(ApiRoutes.Transaction.StateI)]
        public IActionResult PostStateI([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = TransactionService.PostStateI(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Transaction.StateI)]
        public IActionResult GetStateI([FromRoute] string Accept, string Authorization)
        {
            var response = TransactionService.GetStateI(Accept, Authorization);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Transaction.StateII)]
        public IActionResult PostStateII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = TransactionService.PostStateII(ContentType, Accept, Authorization, Body);

            return Ok(Response);

        }

        [HttpPost(ApiRoutes.Transaction.StateIII)]
        public IActionResult PostStateIII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = TransactionService.PostStateIII(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpPut(ApiRoutes.Transaction.StateIV)]
        public IActionResult PutStateIV([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = TransactionService.PutStateIV(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }


        [HttpPost(ApiRoutes.Transaction.StateV)]
        public IActionResult PostStateV([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = TransactionService.PostStateV(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Transaction.StateVI)]
        public IActionResult PostStateVI([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = TransactionService.PostStateVI(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Transaction.StateVII)]
        public IActionResult PostStateVII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = TransactionService.PostStateVII(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Transaction.StateVIII)]
        public IActionResult PostStateVIII([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = TransactionService.PostStateVIII(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Transaction.StateIX)]
        public IActionResult PostStateIX([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = TransactionService.PostStateIX(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Transaction.StateX)]
        public IActionResult PostStateX([FromRoute] string ContentType, string Accept, string Authorization, string Body)
        {
            var response = TransactionService.PostStateX(ContentType, Accept, Authorization, Body);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Transaction.StateXI)]
        public IActionResult GetStateXI([FromRoute] string Accept, string Authorization, string transaction_id)
        {
            var response = TransactionService.GetStateXI(Accept, Authorization, transaction_id);

            return Ok(Response);
        }

        [HttpPut(ApiRoutes.Transaction.StateXI)]
        public IActionResult PutStateXI([FromRoute] string ContentType, string Accept, string Authorization, string Body, string transaction_id)
        {
            var response = TransactionService.PutStateXI(ContentType, Accept, Authorization, Body, transaction_id);

            return Ok(Response);
        }

        [HttpGet(ApiRoutes.Transaction.StateXII)]
        public IActionResult GetStateXII([FromRoute] string Accept, string Authorization, string transaction_id)
        {
            var response = TransactionService.GetStateXII(Accept, Authorization, transaction_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Transaction.StateXIII)]
        public IActionResult PostStateXIII([FromRoute] string ContentType, string Accept, string Authorization, string file, string transaction_id)
        {
            var response = TransactionService.PostStateXIII(ContentType, Accept, Authorization, file, transaction_id);

            return Ok(Response);
        }

        [HttpPost(ApiRoutes.Transaction.StateXIV)]
        public IActionResult PostStateXIV([FromRoute] string ContentType, string Accept, string Authorization, string transaction_id)
        {
            var response = TransactionService.PostStateXIV(ContentType, Accept, Authorization, transaction_id);

            return Ok(Response);
        }


    }
}




