using FinancialCurrency.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public interface IWebhookService
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
        object PostStateI(string contentType, string accept, string authorization, string body);
        object DeleteStateI(string accept, string authorization);
        object GetStateI(string accept, string authorization);
        object GetStateII(string accept, string authorization);
        object PostStateIII(string contentType, string accept, string authorization, string body);
    }
}
