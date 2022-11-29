using FinancialCurrency.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public interface ILedgersService
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
        object GetStateI(string accept, string authorization);
        object PostStateI(string contentType, string accept, string authorization, string body);
        object GetStateII(string iban, string accept, string authorization);
        object GetStateIII(string uk_account_number, string uk_sort_code, string accept, string authorization);
        object GetStateIV(string accept, string authorization);
        object GetStateV(string accept, string authorization);
        object PostStateVI(string contentType, string accept, string authorization, string body);
        object GetStateVII(string accept, string authorization, string ledger_id);
        object PostStateVIII(string contentType, string accept, string authorization, string body);
        object PostStateIX(string contentType, string accept, string authorization, string ledger1_id);
        object PostStateX(string contentType, string accept, string authorization, string ledger1_id);
        object GetStateXI(string ledger_id, string accept, string authorization, string ledger1_id);
        object PostStateXII(string contentType, string accept, string authorization, string ledger1_id);
        object PostStateXIII(string contentType, string accept, string authorization, string ledger1_id);
    }
}