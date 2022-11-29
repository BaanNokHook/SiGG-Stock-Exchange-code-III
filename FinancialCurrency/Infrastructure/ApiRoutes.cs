using FinancialCurrency.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
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

        public static class Beneficiaries
        {
            public const string Quater = Base + "/beneficiaries";
            public const string Profile = Base + "/beneficiaries";
            public const string Stream = Base + "/beneficiaries/{beneficiary_id}";
            public const string Vapor = Base + "/beneficiaries/{beneficiary_id}/accounts";  
            public const string Backlog = Base + "/beneficiaries/{beneficiary_id}/accounts/{account_id}";  
            public const string Makedefault = Base + "/beneficiaries/{beneficiary_id}/accounts/{account_id}/make-default";  
            public const string Compliance = Base + "/beneficiaries/{beneficiary_id}/compliance-firewall-calculation";
            public const string Firewall = Base + "/beneficiaries/{beneficiary_id}/rerun-firewall"; 
            public const string Wait = Base + "/beneficiaries/{beneficiary_id}/wait";
            public const string LastBenefit = Base + "/beneficiary-accounts/{accountid}";
        }


        public static class Cards
        {
            public const string StateI = Base + "/cards";
            public const string StateII = Base + "/cards/by-token/{card_token}";
            public const string StateIII = Base + "/cards/rules";
            public const string StateIV = Base + "/cards/rules/{card_rule_1}";
            public const string StateV = Base + "/cards/rules/{card_rule_1}/disable";
            public const string StateVI = Base + "/cards/{card_id}";
            public const string StateVII = Base + "/cards";
            public const string StateVIII = Base + "/cards";
            public const string StateIX = Base + "/cards";
            public const string StateX = Base + "/cards";
            public const string StateXI = Base + "/cards";
            public const string StateXII = Base + "/cards";
            public const string StateXIII = Base + "/cards";
            public const string StateXIV = Base + "/cards";
            public const string StateXV = Base + "/cards";
            public const string StateXVI = Base + "/cards";

        }
        public static class Trade
        {
            public const string Openport = Base + "/trade";
            public const string Brokers = Base + "/trades/{tradesId}";

        }
    }
}

