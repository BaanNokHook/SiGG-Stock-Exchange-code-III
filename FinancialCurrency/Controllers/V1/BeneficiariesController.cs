using FinancialCurrency.API.Infrastructure;
using FinancialCurrency.API.Services;
using FinancialCurrency.API.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FinancialCurrency.API.Controllers.V1
{
    //[Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class BeneficiariesController : ControllerBase
    {
        private readonly IBeneficiariesService BeneficiariesService;
        private object DateTime;
        private object Summaries;

        public BeneficiariesController(IBeneficiariesService BeneficiariesService)
        {
            //this.config = config  
            this.BeneficiariesService = BeneficiariesService;
        }

        [HttpPost(ApiRoutes.Beneficiaries.Quater)]
        public IActionResult Quater([FromRoute] long ContentType, long Accept, long Authorization, long Body)
        {
            var response = BeneficiariesService.ContentType(ContentType, Accept, Authorization, Body);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Beneficiaries.Quater)]
        public IActionResult Quater([FromRoute] long Accept, long Authorization)
        {
            var response = BeneficiariesService.Profile(Accept, Authorization);

            return Ok(response);
        }

        [HttpPut(ApiRoutes.Beneficiaries.Stream)]
        public IActionResult Session([FromRoute] long ContentType, long Accept, long Authorization, long Body, string beneficiary_id)
        {
            var response = BeneficiariesService.Session(ContentType, Accept, Authorization, Body, beneficiary_id);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Beneficiaries.Stream)]
        public IActionResult GetSession([FromRoute] long Accept, long Authorization, string beneficiary_id)
        {
            var response = BeneficiariesService.GetSession(Accept, Authorization, beneficiary_id);

            return Ok(response);
        }

        [HttpPost(ApiRoutes.Beneficiaries.Vapor)]
        public IActionResult PostVapor([FromRoute] long ContentType, long Accept, long Authorization, long body, string beneficiary_id)
        {

            var response = BeneficiariesService.PostVapor(ContentType, Accept, Authorization, beneficiary_id);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Beneficiaries.Vapor)]
        public IActionResult GetVapor([FromRoute] long Accept, long Authorization, string beneficiary_id)
        {
            var response = BeneficiariesService.GetVapor(Accept, Authorization, beneficiary_id);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Beneficiaries.Backlog)]

        public IActionResult GetBacklog([FromRoute] long Accept, long Authorization, string beneficiary_id, string account_id)
        {
            var response = BeneficiariesService.GetBacklog(Accept, Authorization, beneficiary_id, account_id);

            return Ok(response);
        }

        [HttpPut(ApiRoutes.Beneficiaries.Backlog)]
        public IActionResult PutBacklog([FromRoute] long ContentType, long Accept, long Authorization, long body, string beneficiary_id)
        {
            var response = BeneficiariesService.PutBacklog(ContentType, Accept, Authorization, beneficiary_id);

            return Ok(response);
        }

        [HttpPut(ApiRoutes.Beneficiaries.Makedefault)]
        public IActionResult PutMakedefault([FromRoute] long ContentType, long Accept, long Authorization, long body, string beneficiary_id, string account_id)
        {
            var response = BeneficiariesService.PutMakedefault(ContentType, Accept, Authorization, beneficiary_id, account_id);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Beneficiaries.Compliance)]
        public IActionResult GetCompliance([FromRoute] long Accept, long Authorization, string beneficiary_id)
        {
            var response = BeneficiariesService.GetCompliance(Accept, Authorization, beneficiary_id);

            return Ok(response);

        }

        [HttpPost(ApiRoutes.Beneficiaries.Firewall)]
        public IActionResult PostFirewall([FromRoute] long Accept, long Authorization, string beneficiary_id)
        {
            var response = BeneficiariesService.PostFirewall(Accept, Authorization, beneficiary_id);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Beneficiaries.Wait)]
        public IActionResult GetWait([FromRoute] long Accept, long Authorization, string beneficiary_id)
        {
            var response = BeneficiariesService.GetWait(Accept, Authorization, beneficiary_id);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Beneficiaries.LastBenefit)]
        public IActionResult GetLastBenefit([FromRoute] long Accept, long Authorization, string account_id)
        {
            var response = BeneficiariesService.GetLastBenefit(Accept, Authorization, account_id);

            return Ok(response);
        }
    }

    internal class GetAlreadyRegisterController
    {
        public object Date { get; set; }
        public object TemperatureC { get; set; }
        public object Summary { get; set; }
    }
}

