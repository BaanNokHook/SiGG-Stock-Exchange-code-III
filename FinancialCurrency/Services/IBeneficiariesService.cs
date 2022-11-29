using FinancialCurrency.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FinancialCurrency.API.Services
{
        public interface IBeneficiariesService
        {
            ResponseVm Quater(long ContentType);
            ResponseVm Profile(long Accept, decimal amount);
            ResponseVm Stream(long Authorization, decimal amount);
            ResponseVm Backlog(long Body);
            ResponseVm Makedefault(long ContentType, long Authorization, long Accept, string beneficiary_id, string account_id);
            ResponseVm Compliance(long Accept, long Authorization, string beneficiary_id);
            ResponseVm Firewall(long Accept, long Authorization, string beneficiary_id);
            ResponseVm Wait(long Accept, long Authorization, string beneficiary_id);
            ResponseVm LastBenefit(long Accept, long Authorization, string beneficiary_id);


        object Profile(long accept);
            object Quater(Func<long, IActionResult> accept);
            object ContentType(long contentType, long accept, long authorization, long body);
            object Profile(long contentType, long accept, long authorization, long body);
            object Session(long contentType, long accept, long authorization, long body, string beneficiary_id);
            object GetSession(long accept, long authorization, string beneficiary_id);
            object PostVapor(long contentType, long accept, long authorization, string beneficiary_id);
            object GetVapor(long accept, long authorization, string beneficiary_id);
            object GetBacklog(long accept, long authorization, string beneficiary_id, string account_id);
            object PutBacklog(long contentType, long accept, long authorization, string beneficiary_id);
            object PutMakedefault(long contentType, long accept, long authorization, string beneficiary_id, string account_id);
            object GetCompliance(long accept, long authorization, string beneficiary_id);
            object PostFirewall(long accept, long authorization, string beneficiary_id);
            object GetWait(long accept, long authorization, string beneficiary_id);
            object GetLastBenefit(long accept, long authorization, string account_id);
    }
    
}



