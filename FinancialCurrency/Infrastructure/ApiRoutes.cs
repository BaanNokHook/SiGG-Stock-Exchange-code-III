using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialCurrency.API.Infrastructure
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Account
        {
            public const string AccountInfo = Base + "/account/{userId}";
            public const string Convert = Base + "/convert/{userId}";
            public const string Deposit = Base + "/deposit/{userId}/{amount}"; 
            public const string Withdraw = Base + "/withdraw/{userId}/{amount}";
        }

        public static class Bank
        {
            public const string BankInfo = Base + "/bankvalidateUKBankAccount/{banksId}";
            public const string BankConvert = Base + "/bankSearchresult/{issuerName}";
            public const string BankDeposit = Base + "/bankvalidateIbanAdvanced/{banksId}/{amount}";
            public const string BankRequest = Base + "/bankvalidateDomesticAccount/{banksId}/{request}";
            public const string BankWithdraw = Base + "/bankGiophyresult/{year}";
    
        }

        public static class Trade
        {
            public const string Openport = Base + "/trade";
            public const string Brokers = Base + "/trades/{tradesId}";

        }
    }
}
