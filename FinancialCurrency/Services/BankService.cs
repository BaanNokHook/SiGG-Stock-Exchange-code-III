//using FinancialCurrency.API.ViewModels;
//using FinancialCurrency.Domain;
//using FinancialCurrency.Domain.Common;
//using FinancialCurrency.Domain.UserAggregate;
//using System;
//using System.Threading.Tasks;
//using static FinancialCurrency.API.Infrastructure.ApiRoutes;

//namespace FinancialCurrency.API.Services
//{
//    public class BankService : IBankService
//    {
//        private readonly ICurrencyService currencyService;
//        private readonly IUserService userService;

//        public BankService(IUserService userService, ICurrencyService currencyService)
//        {
//            this.userService = userService ?? throw new ArgumentNullException(nameof(userService));
//            this.currencyService = currencyService ?? throw new ArgumentNullException(nameof(currencyService)); ;
//        }

//        public ReemVm ConvertToCurrency(long userId, string targetCurrencyStr)
//        {
//            //3 c. Перевести деньги из одной валюты в другую
//            var user = userService.GetById(userId);
//            var targetCurrency = Currency.Parse(targetCurrencyStr);
//            var fromCurrency = user.Bank.Balance.SelectedCurrency;
//            if (targetCurrency == fromCurrency)
//            {
//                throw new ArgumentException("Невозможно конвертировать в одинаковую валюту ");
//            }

//            var conversionAmount = currencyService.GetConversionAmount(user.Bank.Balance.SelectedCurrency, targetCurrency, user.Bank.Balance.Amount);
//            user.Bank.ConvertToCurrency(targetCurrency, conversionAmount);

//            var responseMsg = $"Конвертация валюты с {fromCurrency} в {targetCurrency.ToString()}. Баланс: {user.Bank.Balance.ToString()}.";

//            return CreateReemVm(user.Bank.Balance.Amount, user.Bank.Balance.SelectedCurrency, responseMsg);
//        }

//        public ReemVm Deposit(long userId, decimal amount)
//        {
//            //3 a. Пополнить кошелек в одной из валют
//            var user = userService.GetById(userId);
//            user.Bank.Deposit(new Money(amount, user.Bank.Balance.SelectedCurrency));

//            var responseMsg = $"Кошелек пополнен на: {amount} {user.Bank.Balance.SelectedCurrency}. Баланс: {user.Bank.Balance.ToString()}.";

//            return CreateReemVm(user.Bank.Balance.Amount, user.Bank.Balance.SelectedCurrency, responseMsg);
//        }

//        public ReemVm GetBankInfo(long userId)
//        {
//            //3 d. Получить состояние своего кошелька (сумму денег в каждой из валют)
//            var user = userService.GetById(userId);
//            var moneyCollection = GetConvertedMoneyCollection(user.Bank);
//            var responseMsg = new BankInfo(user.Bank.Balance, moneyCollection).ToString();

//            return CreateReemVm(user.Bank.Balance.Amount, user.Bank.Balance.SelectedCurrency, responseMsg);
//        }

//        private ReemVm CreateReemVm(object amount, object selectedCurrency, string responseMsg)
//        {
//            throw new NotImplementedException();
//        }

//        private object GetConvertedMoneyCollection(object bank)
//        {
//            throw new NotImplementedException();
//        }

//        public ReemVm Withdraw(long userId, decimal amount)
//        {
//            //3 b. Снять деньги в одной из валют
//            var user = userService.GetById(userId);
//            user.Bank.Withdraw(new Money(amount, user.Bank.Balance.SelectedCurrency));
//            var responseMsg = $"Снятие денег на: {amount} {user.Bank.Balance.SelectedCurrency}. Баланс: {user.Bank.Balance.ToString()}.";

//            return CreateReemVm(user.Bank.Balance.Amount, user.Bank.Balance.SelectedCurrency, responseMsg);
//        }

//        private ReemVm CreateReemVm(decimal BankBalance, Currency BankCurrency, string message)
//        {
//            return new ReemVm() { Amount = BankBalance, Currency = BankCurrency, Message = message };
//        }

//        private IValueObjectCollection<Money> GetConvertedMoneyCollection(Infrastructure.ApiRoutes.Bank Bank)
//        {
//            var moneyCollection = new ValueObjectCollection<Money>();
//            foreach (var targetCurrency in Bank.Currencies)
//            {
//                //ToDo Domain Policy Validation Pattern
//                if (targetCurrency == Bank.Balance.SelectedCurrency)
//                {
//                    continue;
//                }
//                var conversionResult = currencyService.GetConversionAmount(Bank.Balance.SelectedCurrency, targetCurrency, Bank.Balance.Amount);
//                moneyCollection = (ValueObjectCollection<Money>)moneyCollection.AddImmutable(new Money(conversionResult.ConvertedAmountValue, conversionResult.CurrencyTo));
//            }
//            return moneyCollection;
//        }

//    }
//}