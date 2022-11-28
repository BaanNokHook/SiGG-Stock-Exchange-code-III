using FinancialCurrency.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialCurrency.Infrastructure.Helpers
{
    public static class AccountInit
    {
        private static IEnumerable<Currency> defaultThreeAccountCurrencies = new List<Currency> { Currency.RUB, Currency.USD, Currency.EUR };
        private static IEnumerable<Currency> defaultOneAccountCurrency = new List<Currency> { Currency.IDR };
        
        public static IEnumerable<Bank> GetAllAccounts()
        {
            return GetBaseAccounts();
        }

        public static IEnumerable<Bank> GetAllAccountsWithDuplicate()
        {
            var baseAccountList = GetBaseAccounts();
            var dupeAccountList = baseAccountList.Concat(GetBaseAccounts());

            return dupeAccountList;
        }

        private static IEnumerable<Bank> GetBaseAccounts()
        {
            var accountList = new List<Bank>();
            //accountList.Add(new Account(1000101, new Money(100, Currency.RUB), "Igor", defaultThreeAccountCurrencies));
            //accountList.Add(new Account(1000102, new Money(15000, Currency.RUB), "Petr", defaultThreeAccountCurrencies));
            //accountList.Add(new Account(1000103, new Money(300, Currency.IDR), "Yulia", defaultOneAccountCurrency));
            return accountList;
        }
    }
}
