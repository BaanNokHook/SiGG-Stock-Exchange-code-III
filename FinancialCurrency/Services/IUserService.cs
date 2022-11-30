using FinancialCurrency.Domain;
using System;

namespace FinancialCurrency.API.Services
{
    public interface IUserService
    {
        User GetById(long id);
        object GetById(string beneficiary_id);
        object GetById(Func<long, long, long, long, object> contentType);
    }
}