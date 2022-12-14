using FinancialCurrency.API.Services;
using FinancialCurrency.API.ViewModels;
using FinancialCurrency.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class AccountServiceTest : TestBase<AccountService>
    {
        [TestInitialize]
        public void Setup()
        {
            TestInitializeBase();
        }

        #region Exception Test

        [TestMethod]
        public void When_ConvertCurrency_WithInvalidEqualFromAndToCurrency_ArgumentException()
        {
            var user = uniqueUsers.FirstOrDefault(user => user.Id == 100104); //RUB account
            var accountUnderTest = user.Account;
            var invalidCurrency = Currency.RUB;

            Assert.ThrowsException<ArgumentException>(() => accountService
            .ConvertToCurrency(user.Id, invalidCurrency.ToString()));
        }

        #endregion Exception Test

        #region Logic
        [TestMethod]
        public void Deposit_Valid_Amount_100_Valid_Currency_Rub()
        {
            //3 a.Пополнить кошелек в одной из валют
            var user = uniqueUsers.FirstOrDefault(user => user.Id == 100104);
            var accountUnderTest = user.Account;
            var before_Deposit_Account_Balance = new Money(accountUnderTest.Balance.Amount,
                accountUnderTest.Balance.SelectedCurrency);
            var money_100Rub = new Money(100, Currency.RUB);
            var after_Deposit_Account_Balance = before_Deposit_Account_Balance + money_100Rub;
            var expected = new ResponseVm
            {
                Amount = after_Deposit_Account_Balance.Amount,
                Currency = after_Deposit_Account_Balance.SelectedCurrency,
                Message = "Кошелек пополнен на:  100,00 RUB."
            };

            //Act
            ResponseVm result = accountService.Deposit(user.Id, money_100Rub.Amount);

            Assert.AreEqual(expected.Amount, result.Amount);
            Assert.AreEqual(expected.Currency, result.Currency);
        }

        [TestMethod]
        public void Withdraw_Valid_Amount_100_Valid_Currency_Rub()
        {
            //3 b. Снять деньги в одной из валют
            var user = uniqueUsers.FirstOrDefault(user => user.Id == 100104);
            var accountUnderTest = user.Account;
            var before_Withdraw_Account_Balance = new Money(accountUnderTest.Balance.Amount,
                accountUnderTest.Balance.SelectedCurrency);
            var money_100Rub = new Money(100, Currency.RUB);
            var after_Withdraw_Account_Balance = before_Withdraw_Account_Balance - money_100Rub;
            var expected = new ResponseVm
            {
                Amount = after_Withdraw_Account_Balance.Amount,
                Currency = after_Withdraw_Account_Balance.SelectedCurrency,
                Message = "Кошелек пополнен на:  100,00 RUB."
            };
            //Act
            ResponseVm result = accountService.Withdraw(user.Id, money_100Rub.Amount);

            Assert.AreEqual(expected.Amount, result.Amount);
            Assert.AreEqual(expected.Currency, result.Currency);
        }

        [TestMethod]
        public void ConvertToCurrency_Valid_TargetCurrency()
        {
            //3 c. Перевести деньги из одной валюты в другую
            var user = uniqueUsers.FirstOrDefault(user => user.Id == 100104);
            var accountUnderTest = user.Account;
            var before_Convert_Account_Balance = new Money(accountUnderTest.Balance.Amount,
                accountUnderTest.Balance.SelectedCurrency);
            var targetCurrency = "USD";
            //Act
            ResponseVm result = accountService.ConvertToCurrency(user.Id, targetCurrency);

            Assert.IsTrue(result.Currency == Currency.USD);
            Assert.IsTrue(IsBetween(result.Amount, 130, 180));
        }

        //GetAccountInfo_100_Rub_Other_Currencies_Usd_Eur()
        [TestMethod]
        public void GetAccountInfo_10000_RUB_User_Has_Other_Currencies()
        {
            //3 d. Получить состояние своего кошелька (сумму денег в каждой из валют)
            var user = uniqueUsers.FirstOrDefault(user => user.Id == 100104);            
            var accountUnderTest = user.Account;
            var expected = new ResponseVm
            {
                Amount = accountUnderTest.Balance.Amount,
                Currency = accountUnderTest.Balance.SelectedCurrency,
                Message = $"Основной баланс кошелька: {user.Account.Balance}. Баланс кошелька в других валютах: 153,08 USD, 141,51 EUR."
            };
            //Act
            ResponseVm result = accountService.GetAccountInfo(user.Id);

            Assert.AreEqual(expected.Amount, result.Amount);
            Assert.AreEqual(expected.Currency, result.Currency);
            Assert.IsTrue(result.Message.Contains($"Основной баланс кошелька: {user.Account.Balance}"));
        }
        [TestMethod]
        public void GetAccountInfo_30000_IDR_No_Other_Currecnies()
        {
            var user = uniqueUsers.FirstOrDefault(user => user.Id == 100105);
            var accountUnderTest = user.Account;
            var expected = new ResponseVm
            {
                Amount = accountUnderTest.Balance.Amount,
                Currency = accountUnderTest.Balance.SelectedCurrency,
                Message = $"Основной баланс кошелька: {user.Account.Balance}."
            };
            //Act
            ResponseVm result = accountService.GetAccountInfo(user.Id);

            Assert.AreEqual(expected.Amount, result.Amount);
            Assert.AreEqual(expected.Currency, result.Currency);
            Assert.IsTrue(result.Message.Contains($"Основной баланс кошелька: {user.Account.Balance}"));
        }
        #endregion
    }
}