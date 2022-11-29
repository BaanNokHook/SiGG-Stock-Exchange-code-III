using FinancialCurrency.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public interface ITransactionService
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
        object PostStateI(string contentType, string accept, string authorization, string body);
        object GetStateI(string accept, string authorization);
        object PostStateII(string contentType, string accept, string authorization, string body);
        object PostStateIII(string contentType, string accept, string authorization, string body);
        object PutStateIV(string contentType, string accept, string authorization, string body);
        object PostStateV(string contentType, string accept, string authorization, string body);
        object PostStateVI(string contentType, string accept, string authorization, string body);
        object PostStateVII(string contentType, string accept, string authorization, string body);
        object PostStateVIII(string contentType, string accept, string authorization, string body);
        object PostStateIX(string contentType, string accept, string authorization, string body);
        object PostStateX(string contentType, string accept, string authorization, string body);
        object GetStateXI(string accept, string authorization, string transaction_id);
        object PutStateXI(string accept, string authorization, string transaction_id);
        object PutStateXI(string contentType, string accept, string authorization, string body, string transaction_id);
        object GetStateXII(string accept, string authorization, string transaction_id);
        object PostStateXIII(string contentType, string accept, string authorization, string file, string transaction_id);
        object PostStateXIV(string contentType, string accept, string authorization, string transaction_id);
    }
}
