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
            public const string StateVII = Base + "/cards/{card_id}/activate";
            public const string StateVIII = Base + "/cards/{card_id}/image";
            public const string StateIX = Base + "/cards/{card_id}/suspend";
            public const string StateX = Base + "/cards/{card_id}/pin";

        }

        public static class Compliance
        {
            public const string StateI = Base + "/compliance-contact";
            public const string StateII = Base + "/compliance-firewall-rules/beneficiaries";
            public const string StateIII = Base + "/compliance-firewall-rules/transaction";
            public const string StateIV = Base + "/compliance-firewall-rules/endusers";
            public const string StateV = Base + "/compliance-firewall-rules/beneficiaries/history";
            public const string StateVI = Base + "/compliance-firewall-rules/transactions/history";
            public const string StateVII = Base + "/compliance-firewall-rules/endusers/history";
            public const string StateVIII = Base + "/compliance-firewall-rules/beneficiaries/reload";
            public const string StateIX = Base + "/compliance-firewall-rules/transactions/reload";
            public const string StateX = Base + "/compliance-firewall-rules/endusers/reload";
            public const string StateXI = Base + "/compliance-firewall-rules/beneficiaries/test";
            public const string StateXII = Base + "/compliance-firewall-rules/transactions/test";
            public const string StateXIII = Base + "/compliance-firewall-rules/endusers/test";
            public const string StateXIV = Base + "/compliance-firewall-static-data";
            public const string StateXV = Base + "/compliance-firewall-static-data/{dataset_id}";
            public const string StateXVI = Base + "/compliance-manual";

        }

        public static class DirectDebit
        {
            public const string StateI = Base + "/direct-debit/mandates";
            public const string StateII = Base + "/direct-debit/mandates/{mandate_id}";
            public const string StateIII = Base + "/direct-debit/mandates/{mandate_id}/cancel";
            public const string StateIV = Base + "/direct-debit/payments";
            public const string StateV = Base + "/direct-debit/payments/{payment_id}";
        
        }

        public static class Endusers
        {

            public const string StateI = Base + "/endusers";
            public const string StateII = Base + "/endusers/{enduser_id}";
            public const string StateIII = Base + "/endusers/{enduser_id}/compliance-firewall-calculation";
            public const string StateIV = Base + "/endusers/{enduser_id}/rerun-firewall";
            public const string StateV = Base + "/endusers/{enduser_id}/wait";

        }

        public static class Ledgers
        {
            public const string StateI = Base + "/ledgers";
            public const string StateII = Base + "/ledgers/by-iban";
            public const string StateIII = Base + "/ledgers/by-UK-bank-account";
            public const string StateIV = Base + "/ledgers/changed";
            public const string StateV = Base + "/ledgers/unassigned";
            public const string StateVI = Base + "/ledgers/virtual";
            public const string StateVII = Base + "/ledgers/{ledger_id}";
            public const string StateVIII = Base + "/ledgers/{ledger1_id}/assign";
            public const string StateIX = Base + "/ledgers/{ledger1_id}/assign-iban";
            public const string StateX = Base + "/ledgers/{ledger1_id}/close";
            public const string StateXI = Base + "/ledgers/{ledger1_id}/entries";
            public const string StateXII = Base + "/ledgers/{ledger1_id}/rerun-firewall";
            public const string StateXIII = Base + "/ledgers{ledger1_id}/wait";
            
        }

        public static class Quarantine
        {
            public const string StateI = Base + "/quarantine/";
            public const string StateII = Base + "/quarantine/beneficiaries";
            public const string StateIII = Base + "/quarantine/beneficiaries/{beneficiary_id}";
            public const string StateIV = Base + "/quarantine/beneficiaries/{beneficiary_id}/comments";
            public const string StateV = Base + "/quarantine/beneficiaries/{beneficiary_id}/resolve";
            public const string StateVI = Base + "/quarantine/endusers";
            public const string StateVII = Base + "/quarantine/endusers/{enduser_id}";
            public const string StateVIII = Base + "/quarantine/beneficiaries/{enduser_id}/comments";
            public const string StateIX = Base + "/quarantine/beneficiaries/{enduser_id}/resolve";
            public const string StateX = Base + "/quarantine/transactions";
            public const string StateXI = Base + "/quarantine/transactions/{transaction_id}";
            public const string StateXII = Base + "/quarantine/beneficiaries/{transaction_id}/comments";
            public const string StateXIII = Base + "/quarantine/beneficiaries/{transaction_id}/resolve";

        }

        public static class Transaction
        {
            public const string StateI = Base + "/transactions/";
            public const string StateII = Base + "/transactions/bulk";
            public const string StateIII = Base + "/transactions/fx";
            public const string StateIV = Base + "/transactions/fx/quote";
            public const string StateV = Base + "/transactions/inter-ledger";
            public const string StateVI = Base + "/transactions/inter-ledger/bulk";
            public const string StateVII = Base + "/transactions/inter-ledger/try";
            public const string StateVIII = Base + "/transactions/manual-credit";
            public const string StateIX = Base + "/transactions/manual-debit";
            public const string StateX = Base + "/transactions/try";
            public const string StateXI = Base + "/transactions/{transaction_id}";
            public const string StateXII = Base + "/transactions/{transaction_id}/compliance-firewall-calculation";
            public const string StateXIII = Base + "/transactions/{transaction_id}/invoices";
            public const string StateXIV = Base + "/transactions/{transaction_id}/rerun-firewall";

        }

        public static class Webhook
        {
            public const string StateI = Base + "/webhook";
            public const string StateII = Base + "/webhook/failed-to-deliver";
            public const string StateIII = Base + "/webhook/update-secret";
           
        }

        public static class Trade
        {
            public const string Openport = Base + "/trade";
            public const string Brokers = Base + "/trades/{tradesId}";

        }
    }
}

