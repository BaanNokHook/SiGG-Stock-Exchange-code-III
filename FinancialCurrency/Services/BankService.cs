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

        public ReemVm BankConvertToCurrency(long userId, string targetCurrencyStr)
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

            return CreateReemVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        public ReemVm BankDeposit(long userId, decimal amount)
        {

            var user = userService.GetById(userId);
            user.Account.BankDeposit(new Money(amount, user.Account.Balance.SelectedCurrency));

            var responseMsg = $"Wallet topped up on: {amount} {user.Account.Balance.SelectedCurrency}. Balance: {user.Account.Balance.ToString()}.";

            return CreateReemVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        public ReemVm GetBankInfo(long userId)
        {
           
            var user = userService.GetById(userId);
            var moneyCollection = GetBankConvertedMoneyCollection(user.Account);
            var responseMsg = new BankInfo(user.Account.Balance, moneyCollection).ToString();

            return CreateReemVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        public ReemVm BankWithdraw(long userId, decimal amount)
        {
     
            var user = userService.GetById(userId);
            user.Account.BankWithdraw(new Money(amount, user.Account.Balance.SelectedCurrency));
            var responseMsg = $"BankWithdrawing money for: {amount} {user.Account.Balance.SelectedCurrency}. Balance: {user.Account.Balance.ToString()}.";

            return CreateReemVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        private ReemVm CreateReemVm(decimal accountBalance, Currency accountCurrency, string message)
        {
            return new ReemVm() { Amount = accountBalance, Currency = accountCurrency, Message = message };
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

        public ReemVm ConvertToCurrency(long userId, string currTo)
        {
            throw new NotImplementedException();
        }

        public ReemVm Deposit(long userId, decimal amount)
        {
            throw new NotImplementedException();
        }

        public ReemVm Withdraw(long userId, decimal amount)
        {
            throw new NotImplementedException();
        }

        public ReemVm GetAccountInfo(long userId)
        {
            throw new NotImplementedException();
        }

        object IBankService.GetBankInfo(long userId)
        {
            throw new NotImplementedException();
        }

        public object ConvertToCurrency(long issuerName)
        {
            throw new NotImplementedException();
        }

        public object Request(long banksId, decimal request)
        {
            throw new NotImplementedException();
        }
    }
}


   