
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
        public string UserName { get; private set; } //для усиления идентичности (Equals, GetHashCode) дублируем имя из User



        public Bank ConvertToCurrency(Currency targetCurrency, ConversionAmount conversionResult)
        {

            if (targetCurrency == Balance.SelectedCurrency)
            {
                throw new ArgumentException("Невозможно конвертировать в одинаковую валюту ");
            }

            Balance = new Money(conversionResult.ConvertedAmountValue, conversionResult.CurrencyTo);
            return this;
        }

        public void Deposit(Money money)
        {
            if (money.Amount < 0)
            {
                throw new ArgumentOutOfRangeException("Пополнение невозможно. Значение не может быть ниже нуля.");
            }
            if (money.Amount == 0)
            {
                throw new InvalidOperationException("Для пополнения кошелька укажите суммму выше нуля.");
            }
            Balance += money;
        }

        public void Withdraw(Money money)
        {
            if (money.Amount > Balance.Amount)
            {
                throw new ArgumentOutOfRangeException("Снятие невозможно. Запрашиваемая сумма выше доступных средтв.");
            }
            if (money.Amount < 0)
            {
                throw new ArgumentOutOfRangeException("Снятие невозможно. Значение не может быть ниже нуля.");
            }
            if (money.Amount == 0)
            {
                throw new ArgumentException("Для снятия денежных средств укажите суммму выше нуля.");
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