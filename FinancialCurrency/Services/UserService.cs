using FinancialCurrency.Domain;
using FinancialCurrency.Domain.UserAggregate;
using System;

namespace FinancialCurrency.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public User GetById(long id)
        {
            return userRepository.GetById(id);
        }

        public object GetById(string beneficiary_id)
        {
            throw new NotImplementedException();
        }

        public object GetById(Func<long, long, long, long, object> contentType)
        {
            throw new NotImplementedException();
        }
    }
}