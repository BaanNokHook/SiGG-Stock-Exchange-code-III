using FinancialCurrency.Domain.Common;

namespace FinancialCurrency.Domain.UserAggregate
{
    public interface IUserRepository : IRepository<User>
    {
        User GetById(long id);
    }
}