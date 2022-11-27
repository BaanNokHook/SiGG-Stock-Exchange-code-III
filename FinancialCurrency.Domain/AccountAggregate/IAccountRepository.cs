using FinancialCurrency.Domain.Common;

namespace FinancialCurrency.Domain.AccountAggregate
{
    public interface IAccountRepository : IRepository<Account>
    {
        public Account GetById(int id);
    }
}