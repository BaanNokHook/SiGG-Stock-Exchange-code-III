using FinancialCurrency.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public interface IQuarantineService
    {
        ResponseVm StateI(string ContentType);
        ResponseVm StateII(string ContentType);
        ResponseVm StateIII(string ContentType);
        ResponseVm StateIV(string ContentType);
        ResponseVm StateV(string ContentType);
        ResponseVm StateVI(string ContentType);
        ResponseVm StateVII(string ContentType);
        ResponseVm StateVIII(string ContentType);
        ResponseVm StateIX(string ContentType);
        ResponseVm StateX(string ContentType);
        ResponseVm StateXI(string ContentType);
        ResponseVm StateXII(string ContentType);
        ResponseVm StateXIII(string ContentType);
        ResponseVm StateXIV(string ContentType);
        ResponseVm StateXV(string ContentType);
        ResponseVm StateXVI(string ContentType);
        ResponseVm StateXVII(string ContentType);
        ResponseVm StateXVIII(string ContentType);
        ResponseVm StateXIX(string ContentType);
        ResponseVm StateXX(string ContentType);
        object GetStateI(string accept, string authorization);
        object GetStateII(string accept, string authorization);
        object GetStateIII(string accept, string authorization, string beneficiary_id);
        object PostStateIV(string contentType, string accept, string authorization, string body, string beneficiary_id);
        object PostStateV(string contentType, string accept, string authorization, string body, string beneficiary_id);
        object GetStateVI(string accept, string authorization);
        object GetStateVII(string accept, string authorization, string enduser_id);
        object PostStateVIII(string contentType, string accept, string authorization, string body, string enduser_id);
        object PostStateIX(string contentType, string accept, string authorization, string body, string enduser_id);
        object GetStateX(string accept, string authorization);
        object GetStateXI(string accept, string authorization, string transaction_id);
        object PostStateXII(string contentType, string accept, string authorization, string body, string transaction_id);
        object PostStateXIII(string contentType, string accept, string authorization, string body, string transaction_id);
    }
}
