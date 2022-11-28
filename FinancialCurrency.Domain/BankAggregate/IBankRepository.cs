using FinancialCurrency.Domain.Common;

namespace FinancialCurrency.Domain.AccountAggregate
{
    public interface IBankRepository : IRepository<Bank>
    {
        public Bank GetById(int id);
    }
}