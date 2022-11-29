using FinancialCurrency.API.ViewModels;
using FinancialCurrency.Domain;
using FinancialCurrency.Domain.Common;
using FinancialCurrency.Domain.UserAggregate;
using System;
using System.Threading.Tasks;

namespace FinancialCurrency.API.Services
{
    public class BankService : IBankService
    {
        private readonly ICurrencyService currencyService;
        private readonly IUserService userService;

        public BankService(IUserService userService, ICurrencyService currencyService)
        {
            this.userService = userService ?? throw new ArgumentNullException(nameof(userService));
            this.currencyService = currencyService ?? throw new ArgumentNullException(nameof(currencyService)); ;
        }

        public ResponseVm BankConvertToCurrency(long userId, string targetCurrencyStr)
        {
            
            var user = userService.GetById(userId);
            var targetCurrency = Currency.Parse(targetCurrencyStr);
            var fromCurrency = user.Account.Balance.SelectedCurrency;
            if (targetCurrency == fromCurrency)
            {
                throw new ArgumentException("Cannot BankConvert to the same currency");
            }

            var conversionAmount = currencyService.GetConversionAmount(user.Account.Balance.SelectedCurrency, targetCurrency, user.Account.Balance.Amount);
            user.Account.BankConvertToCurrency(targetCurrency, conversionAmount);

            var responseMsg = $"Currency conversion from c {fromCurrency} в {targetCurrency.ToString()}. Balance: {user.Account.Balance.ToString()}.";

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        public ResponseVm BankDeposit(long userId, decimal amount)
        {

            var user = userService.GetById(userId);
            user.Account.BankDeposit(new Money(amount, user.Account.Balance.SelectedCurrency));

            var responseMsg = $"Wallet topped up on: {amount} {user.Account.Balance.SelectedCurrency}. Balance: {user.Account.Balance.ToString()}.";

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        public ResponseVm GetBankInfo(long userId)
        {
           
            var user = userService.GetById(userId);
            var moneyCollection = GetBankConvertedMoneyCollection(user.Account);
            var responseMsg = new BankInfo(user.Account.Balance, moneyCollection).ToString();

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        public ResponseVm BankWithdraw(long userId, decimal amount)
        {
     
            var user = userService.GetById(userId);
            user.Account.BankWithdraw(new Money(amount, user.Account.Balance.SelectedCurrency));
            var responseMsg = $"BankWithdrawing money for: {amount} {user.Account.Balance.SelectedCurrency}. Balance: {user.Account.Balance.ToString()}.";

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        private ResponseVm CreateResponseVm(decimal accountBalance, Currency accountCurrency, string message)
        {
            return new ResponseVm() { Amount = accountBalance, Currency = accountCurrency, Message = message };
        }

        private IValueObjectCollection<Money> GetBankConvertedMoneyCollection(Bank account)
        {
            var moneyCollection = new ValueObjectCollection<Money>();
            foreach (var targetCurrency in account.Currencies)
            {
                //ToDo Domain Policy Validation Pattern
                if (targetCurrency == account.Balance.SelectedCurrency)
                {
                    continue;
                }
                var conversionResult = currencyService.GetConversionAmount(account.Balance.SelectedCurrency, targetCurrency, account.Balance.Amount);
                moneyCollection = (ValueObjectCollection<Money>)moneyCollection.AddImmutable(new Money(conversionResult.BankConvertedAmountValue, conversionResult.CurrencyTo));
            }
            return moneyCollection;           
        }
    }
}