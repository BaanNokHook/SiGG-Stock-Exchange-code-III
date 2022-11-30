using FinancialCurrency.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinancialCurrency.API.Services
{
    public interface ICardsService
    {

        ResponseVm StateI(string contentType, string accept, string authorization, string body);
        ResponseVm StateII(string accept, string authorization);
        ResponseVm StateIII(string contentType, string accept, string authorization, string body);
        ResponseVm StateIV(string accept, string authorization, string card_rule_1);
        ResponseVm StateV(string contentType, string accept, string authorization, string card_rule_1);
        ResponseVm StateVI(string accept, string authorization, string card_id);
        ResponseVm StateVII(string contentType, string accept, string authorization, string card_id);
        ResponseVm StateVIII(string contentType, string accept, string authorization, string card_id);
        ResponseVm StateIX(string contentType, string accept, string authorization, string card_id);
        ResponseVm StateX(string card_id);
        ResponseVm StateXI(string ContentType);
        ResponseVm StateXII(string ContentType);
        ResponseVm StateXIII(string ContentType);
        ResponseVm StateXIV(string ContentType);
        ResponseVm StateXV(string ContentType);



        object PostStateI(string contentType, string accept, string authorization, string body);
        object GetStateI(string accept, string authorization);
        object GetStateII(string accept, string authorization, string card_token);
        object PostStateIII(string contentType, string accept, string authorization, string body);
        object GetStateIII(string accept, string authorization);
        object GetStateIV(string accept, string authorization, string card_rule_1);
        object PostStateV(string contentType, string accept, string authorization, string card_rule_1);
        object GetStateVI(string accept, string authorization, string card_id);
        object PutStateVI(string contentType, string accept, string authorization, string body, string card_id);
        object PostStateVII(string contentType, string accept, string authorization, string card_id);
        object GetStateVIII(string accept, string authorization, string card_id);
        object PostStateIX(string contentType, string accept, string authorization, string card_id);
        object GetStateX(string card_id);
    }
}