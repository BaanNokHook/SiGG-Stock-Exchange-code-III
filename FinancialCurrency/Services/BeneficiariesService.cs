using FinancialCurrency.API.ViewModels;
using FinancialCurrency.Domain;
using FinancialCurrency.Domain.Common;
using FinancialCurrency.Domain.UserAggregate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialCurrency.API.Services
{
    public class BeneficiariesService : IBeneficiariesService
    {
        private readonly ICurrencyService currencyService;
        private readonly IUserService userService;
        private object targetCurrency;
        private object fromCurrency;
        private object accountBalance;
        private object accountCurrency;
        private string message;

        public BeneficiariesService(IUserService userService, ICurrencyService currencyService)
        {
            this.userService = userService ?? throw new ArgumentException(nameof(userService));
            this.currencyService = currencyService ?? throw new ArgumentNullException(nameof(currencyService));

        }

        public BeneficiariesService()
        {
        }

        public BeneficiariesService(ICurrencyService currencyService, IUserService userService, object targetCurrency, object fromCurrency, object accountBalance, object accountCurrency, string message)
        {
            this.currencyService = currencyService;
            this.userService = userService;
            this.targetCurrency = targetCurrency;
            this.fromCurrency = fromCurrency;
            this.accountBalance = accountBalance;
            this.accountCurrency = accountCurrency;
            this.message = message;
        }

        public ResponseVm Quater(long ContentType)
        {
            var user = userService.GetById(ContentType);
            if (targetCurrency == fromCurrency)
            {
                throw new ArgumentException("Cannot BankConvert to the same currency");
            }

            var conversionAmount = currencyService.GetConversionAmount(user.Account.Balance.SelectedCurrency, targetCurrency, user.Account.Balance.Amount);
            var responseMsg = $"Currency conversion from c {fromCurrency} B {targetCurrency.ToString()}. Balance: {user.Account.Balance.ToString()}.";

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);

        }

        private ResponseVm CreateResponseVm(decimal amount, Currency selectedCurrency, string responseMsg)
        {
            throw new NotImplementedException();
        }

        public ResponseVm Profile(long Accept, decimal amount)
        {
            var user = userService.GetById(Accept);
            user.Account.BankDeposit(new Money(amount, user.Account.Balance.SelectedCurrency));

            var responseMsg = $"Wallet topped up on: {amount} {user.Account.Balance.SelectedCurrency}. Balance: {user.Account.Balance.ToString()}.";
            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);

        }

        public ResponseVm Stream(long Authorization, decimal amount)
        {
            var user = userService.GetById(Authorization);
            var moneyCollection = GetBankConvertedMoneyCollection(user.Account);
            var responseMsg = new BankInfo(user.Account.Balance, moneyCollection).ToString();

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        public ResponseVm Backlog(long Body)
        {

            var user = userService.GetById(Body);
            var moneyCollection = GetBankConvertedMoneyCollection(user.Account);
            var responseMsg = new BankInfo(user.Account.Balance, moneyCollection).ToString();

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        public ResponseVm Makedefault(long ContentType, long Authorization, long Accept, string beneficiary_id, string account_id)
        {

            var user = userService.GetById(ContentType);
            user.Account.Makedefault(new Money(ContentType, user.Account.Balance.SelectedCurrency));
            var responseMsg = $"Makedefault money for: {ContentType} {user.Account.Balance.SelectedCurrency}. Balance: {user.Account.Balance.ToString()}.";

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }

        private ResponseVm Compliance(long Accept, long Authorization, string beneficiary_id)
        {
            return new ResponseVm() { Accept = accountBalance, Authorization = accountCurrency, Message = message };
        }


        public ResponseVm Firewall(long Accept, long Authorization, string beneficiary_id)
        {

            var user = userService.GetById(Accept);
            var user_1 = userService.GetById(Authorization);
            var user_2 = userService.GetById(beneficiary_id);
            var moneyCollection = GetBankConvertedMoneyCollection(user.Account);
            var responseMsg = new BankInfo(user.Account.Balance, moneyCollection).ToString();

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }


        public ResponseVm Wait(long Body, long Authorization, string beneficiary_id)
        {

            var user = userService.GetById(Body);
            var user_1 = userService.GetById(Authorization);
            var user_2 = userService.GetById(beneficiary_id);
            var moneyCollection = GetBankConvertedMoneyCollection(user.Account);
            var responseMsg = new BankInfo(user.Account.Balance, moneyCollection).ToString();

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
        }


        public ResponseVm LastBenefit(long Accept, long Authorization, string beneficiary_id)
        {

            var user = userService.GetById(Accept);
            var user_1 = userService.GetById(Authorization);
            var user_2 = userService.GetById(beneficiary_id);
            var moneyCollection = GetBankConvertedMoneyCollection(user.Account);
            var responseMsg = new BankInfo(user.Account.Balance, moneyCollection).ToString();

            return CreateResponseVm(user.Account.Balance.Amount, user.Account.Balance.SelectedCurrency, responseMsg);
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

        object IBeneficiariesService.GetSession(long userId)
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
        public object Profile(long accept)
        {
            throw new NotImplementedException();
        }

        public object Quater(Func<long, IActionResult> accept)
        {
            throw new NotImplementedException();
        }

        public object ContentType(long contentType, long accept, long authorization, long body)
        {
            throw new NotImplementedException();
        }

        public object Profile(long contentType, long accept, long authorization, long body)
        {
            throw new NotImplementedException();
        }

        public object Session(long contentType, long accept, long authorization, long body, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        public object GetSession(long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        public object PostVapor(long contentType, long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        public object GetVapor(long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        public object GetBacklog(long accept, long authorization, string beneficiary_id, string account_id)
        {
            throw new NotImplementedException();
        }

        public object PutBacklog(long contentType, long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        public object PutMakedefault(long contentType, long accept, long authorization, string beneficiary_id, string account_id)
        {
            throw new NotImplementedException();
        }

        public object GetCompliance(long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        public object PostFirewall(long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        public object GetWait(long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        public object GetLastBenefit(long accept, long authorization, string account_id)
        {
            throw new NotImplementedException();
        }

        ResponseVm IBeneficiariesService.Compliance(long Accept, long Authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        ResponseVm IBeneficiariesService.Quater(long ContentType)
        {
            throw new NotImplementedException();
        }

        ResponseVm IBeneficiariesService.Profile(long Accept, decimal amount)
        {
            throw new NotImplementedException();
        }

        ResponseVm IBeneficiariesService.Stream(long Authorization, decimal amount)
        {
            throw new NotImplementedException();
        }

        ResponseVm IBeneficiariesService.Backlog(long Body)
        {
            throw new NotImplementedException();
        }

        ResponseVm IBeneficiariesService.Makedefault(long ContentType, long Authorization, long Accept, string beneficiary_id, string account_id)
        {
            throw new NotImplementedException();
        }

        ResponseVm IBeneficiariesService.Firewall(long Accept, long Authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        ResponseVm IBeneficiariesService.Wait(long Accept, long Authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        ResponseVm IBeneficiariesService.LastBenefit(long Accept, long Authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.Profile(long accept)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.Quater(Func<long, IActionResult> accept)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.ContentType(long contentType, long accept, long authorization, long body)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.Profile(long contentType, long accept, long authorization, long body)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.Session(long contentType, long accept, long authorization, long body, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.GetSession(long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.PostVapor(long contentType, long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.GetVapor(long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.GetBacklog(long accept, long authorization, string beneficiary_id, string account_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.PutBacklog(long contentType, long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.PutMakedefault(long contentType, long accept, long authorization, string beneficiary_id, string account_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.GetCompliance(long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.PostFirewall(long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.GetWait(long accept, long authorization, string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        object IBeneficiariesService.GetLastBenefit(long accept, long authorization, string account_id)
        {
            throw new NotImplementedException();
        }


        public override bool Equals(object obj)
        {
            return obj is BeneficiariesService service &&
                   EqualityComparer<ICurrencyService>.Default.Equals(currencyService, service.currencyService) &&
                   EqualityComparer<IUserService>.Default.Equals(userService, service.userService) &&
                   EqualityComparer<object>.Default.Equals(targetCurrency, service.targetCurrency) &&
                   EqualityComparer<object>.Default.Equals(fromCurrency, service.fromCurrency) &&
                   EqualityComparer<object>.Default.Equals(accountBalance, service.accountBalance) &&
                   EqualityComparer<object>.Default.Equals(accountCurrency, service.accountCurrency) &&
                   message == service.message;
        }
    }
}