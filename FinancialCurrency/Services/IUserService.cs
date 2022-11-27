using FinancialCurrency.Domain;

namespace FinancialCurrency.API.Services
{
    public interface IUserService
    {
        User GetById(long id);
    }
}