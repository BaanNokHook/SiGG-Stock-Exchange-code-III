
using FinancialCurrency.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinancialCurrency.Domain
{
    public class Bank : Entity<Bank>, IAggregateRoot
    {
        public Bank(long id, Money balance, string userName, IEnumerable<Currency> currencies)
        {
            base.Id = id;
            Balance = balance;
            UserName = userName;
            Currencies = currencies;
        }

        public Money Balance { get; private set; }
        public IEnumerable<Currency> Currencies { get; private set; }
        public string UserName { get; private set; } //to strengthen the identity (Equals, GetHashCode) we duplicate the name from User



        public Bank ConvertToCurrency(Currency targetCurrency, ConversionAmount conversionResult)
        {

            if (targetCurrency == Balance.SelectedCurrency)
            {
                throw new ArgumentException("Cannot convert to the same currency ");
            }

            Balance = new Money(conversionResult.ConvertedAmountValue, conversionResult.CurrencyTo);
            return this;
        }

        public void Deposit(Money money)
        {
            if (money.Amount < 0)
            {
                throw new ArgumentOutOfRangeException("Replenishment is not possible. The value cannot be lower than zero.");
            }
            if (money.Amount == 0)
            {
                throw new InvalidOperationException("To replenish the wallet, specify an amount higher than zero.");
            }
            Balance += money;
        }

        public void Withdraw(Money money)
        {
            if (money.Amount > Balance.Amount)
            {
                throw new ArgumentOutOfRangeException("Removal is not possible. The requested amount is higher than the available funds.");
            }
            if (money.Amount < 0)
            {
                throw new ArgumentOutOfRangeException("Removal is not possible. The value cannot be lower than zero.");
            }
            if (money.Amount == 0)
            {
                throw new ArgumentException("To withdraw funds, enter an amount greater than zero.");
            }
            Balance -= money;
        }

        public override string ToString()
        {
            return $"{Id} {UserName} {Balance}";
        }

        private bool SelectedCurrencyCollisionPolicy(IEnumerable<Currency> currencies)
        {
            if (currencies.Contains(Balance.SelectedCurrency))
            {
                return false;
            }
            return true;
        }

        public void BankConvertToCurrency(Currency targetCurrency, ConversionAmount conversionAmount)
        {
            throw new NotImplementedException();
        }

        public void BankDeposit(Money money)
        {
            throw new NotImplementedException();
        }

        public void BankWithdraw(Money money)
        {
            throw new NotImplementedException();
        }

        public void Makedefault(Money money)
        {
            throw new NotImplementedException();
        }
    }
}