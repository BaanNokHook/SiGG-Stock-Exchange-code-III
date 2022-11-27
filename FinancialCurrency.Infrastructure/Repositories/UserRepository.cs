
using FinancialCurrency.Domain;
using FinancialCurrency.Domain.UserAggregate;
using FinancialCurrency.Infrastructure.Helpers;
using System.Collections.Generic;
using System.Linq;


namespace FinancialCurrency.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IEnumerable<User> _users;


        public UserRepository()
        {
            _users = UsersInit.GetAllUsers();
          
        }

        public User GetById(long id)
        {
            return _users.SingleOrDefault(x => x.Id == id);
        }
    }
}
