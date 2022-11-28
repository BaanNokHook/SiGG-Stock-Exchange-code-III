using FinancialCurrency.Domain;
using FinancialCurrency.Domain.AccountAggregate;
using FinancialCurrency.Infrastructure.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace FinancialCurrency.Infrastructure.Repositories
{
    public class AccountRepository : IBankRepository
    {
        private readonly IEnumerable<Bank> _accounts;

        public AccountRepository()
        {
            _accounts = AccountInit.GetAllAccounts();
        }

        public Bank GetById(int id)
        {
            return _accounts.SingleOrDefault(x => x.Id == id);
        }
    }
}