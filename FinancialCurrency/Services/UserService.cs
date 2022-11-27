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
    }
}