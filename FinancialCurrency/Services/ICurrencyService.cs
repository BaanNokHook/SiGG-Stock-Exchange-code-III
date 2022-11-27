using FinancialCurrency.Domain;

namespace FinancialCurrency.API.Services
{
    public interface ICurrencyService
    {
        ConversionAmount GetConversionAmount(Currency fromCurr, Currency toCurr, decimal amount);
        ConversionExchangeRate GetConversionExchangeRate(Currency fromCurr, Currency toCurr);
    }
}