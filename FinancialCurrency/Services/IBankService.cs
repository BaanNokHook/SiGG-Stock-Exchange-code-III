using FinancialCurrency.API.ViewModels;

namespace FinancialCurrency.API.Services
{
    public interface IBankService
    {
        ReemVm ConvertToCurrency(long userId, string currTo);
        ReemVm Deposit(long userId, decimal amount);
        ReemVm Withdraw(long userId, decimal amount);
        ReemVm GetAccountInfo(long userId);
        object GetBankInfo(long userId);
    }
}