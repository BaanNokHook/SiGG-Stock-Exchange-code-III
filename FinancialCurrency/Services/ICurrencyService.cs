using FinancialCurrency.Domain;

namespace FinancialCurrency.API.Services
{
    public interface ICurrencyService
    {
        ConversionAmount GetConversionAmount(Currency fromCurr, Currency toCurr, decimal amount);
        object GetConversionAmount(Currency selectedCurrency, object targetCurrency, decimal amount);
        object GetConversionAmount(object selectedCurrency, object targetCurrency, object amount);
        ConversionExchangeRate GetConversionExchangeRate(Currency fromCurr, Currency toCurr);
    }
}