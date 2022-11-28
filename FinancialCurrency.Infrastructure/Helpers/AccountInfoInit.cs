using FinancialCurrency.Domain;
using FinancialCurrency.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialCurrency.Infrastructure.Helpers
{
    public static class AccountInfoInit
    {
        public static IEnumerable<BankInfo> GetAccountInfoList()
        {
            return GetBaseAccountInfoList();
        }

        public static IEnumerable<BankInfo> GetAccountInfosWithDuplicate()
        {
            var baseAccountInfoList = GetBaseAccountInfoList();
            var dupeAccountInfoList = baseAccountInfoList.Concat(GetBaseAccountInfoList());

            return dupeAccountInfoList;
        }

        private static IEnumerable<BankInfo> GetBaseAccountInfoList()
        {
            var moneyCollection = MoneyListInit.GetMoneyList1();

            return new List<BankInfo>() {              
                //new AccountInfo(moneyCollection.ElementAt(0), new ValueObjectCollection<Money>(moneyCollection).Take(4)),                      
                //new AccountInfo(moneyCollection.ElementAt(4), new ValueObjectCollection<Money>(moneyCollection.Skip(4).Take(4)))
            };
        }
    }
}
