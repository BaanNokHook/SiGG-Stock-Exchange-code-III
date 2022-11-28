using FinancialCurrency.API.ViewModels;

namespace FinancialCurrency.API.Services
{
    public interface ITradeService
    {
        ReemVm Openport(long API_Key, string currTo);
        ReemVm Brokers(long tradesId, string transactionId);

        object GetOpenport(long API_Key);
        object GetBrokers(long transactionId, string transactionId1);
        object GetBrokers(long tradesId, long transactionId);
    }
}