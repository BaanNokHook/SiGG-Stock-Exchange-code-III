using FinancialCurrency.Domain.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialCurrency.Domain
{
    public class AccountInfo : ValueObject<AccountInfo>
    {
        public AccountInfo(Money balance, IValueObjectCollection<Money> otherCurrencies)
        {
            Balance = balance;
            OtherCurrencies = otherCurrencies;
        }

        public Money Balance { get; }
        public IValueObjectCollection<Money> OtherCurrencies { get; }

        public override string ToString()
        {
            var sb = new StringBuilder($"Main wallet balance: {this.Balance.ToString()}.");
            sb.Append($" Wallet balance in other currencies:");
            var array = OtherCurrencies.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                var money = array[i];
                if (money.SelectedCurrency == Balance.SelectedCurrency)//do not convert to the same currencies - transfer the check to the account
                {
                    continue;
                }

                if (i != array.Length - 1)
                {
                    sb.Append($" {money.ToString()},");
                }
                else
                {
                    sb.Append($" {money.ToString()}.");
                }
            }
            return sb.ToString();
        }

        private IList<Money> DuplicateCurrencyPolicy(Money balance, IEnumerable<Money> otherCurrencies)
        {
            return otherCurrencies.Where(curr => curr.SelectedCurrency != balance.SelectedCurrency).ToList();
        }
    }
}