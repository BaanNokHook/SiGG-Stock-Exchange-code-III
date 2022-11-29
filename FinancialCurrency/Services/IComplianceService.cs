using FinancialCurrency.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FinancialCurrency.API.Services
{
    public interface IComplianceService
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
        ResponseVm StateXXI(string ContentType);
        ResponseVm StateXXII(string ContentType);
        ResponseVm StateXXIII(string ContentType);

        object PostStateI(string contentType, string accept, string authorization, string body);
        object GetStateI(string accept, string authorization);
        object PostStateII(string contentType, string accept, string authorization, string body);
        object GetStateII(string accept, string authorization);
        object PostStateIII(string contentType, string accept, string authorization, string body);
        object GetStateIII(string accept, string authorization);
        object PostStateIV(string contentType, string accept, string authorization, string body);
        object GetStateIV(string accept, string authorization);
        object GetStateV(string accept, string authorization);
        object GetStateVI(string accept, string authorization);
        object GetStateVII(string accept, string authorization);
        object PostStateVIII(string contentType, string accept, string authorization);
        object PostStateIX(string contentType, string accept, string authorization);
        object PostStateX(string contentType, string accept, string authorization);
        object PostStateXI(ContentType contentType, string accept, string authorization, string body);
        object PostStateXI(string contentType, string accept, string authorization, string body);
        object PostStateXII(string contentType, string accept, string authorization, string body);
        object PostStateXIII(string contentType, string accept, string authorization, string body);
        object PostStateXIV(string contentType, string accept, string authorization, string body);
        object GetStateXV(string accept, string authorization, string dataset_id);
        object GetStateXVI(string accept, string authorization);
    }
}