using FinancialCurrency.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Mime;

namespace FinancialCurrency.API.Services
{
    public interface IEndusersService
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

        object GetStateI(string accept, string authorization);
        object PostStateI(string contentType, string accept, string authorization, string body);
        object GetStateII(string accept, string authorization, string enduser_id);
        object GetStateIII(string accept, string authorization, string enduser_id);
        object PostStateIV(string contentType, string accept, string authorization, string enduser_id);
        object GetStateV(string accept, string authorization, string enduser_id);
    }
}


