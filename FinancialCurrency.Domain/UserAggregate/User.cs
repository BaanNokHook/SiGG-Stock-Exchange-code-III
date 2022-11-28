using FinancialCurrency.Domain.Common;
using System;

namespace FinancialCurrency.Domain
{
    public class User : Entity<User>, IAggregateRoot
    {
        public object Bank;

        public string Name { get; private set; }
        public Bank Account { get; private set; }

        public User(long id, string name, Bank account)
        {
            base.Id = id;
            Name = name;
            Account = account;
           
        }

        public override string ToString()
        {
            return $"{Id} {this.Name}";
        }

        
    }
}
