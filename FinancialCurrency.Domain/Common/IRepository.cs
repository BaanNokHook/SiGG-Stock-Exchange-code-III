using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialCurrency.Domain.Common
{
   public interface IRepository<T> where T : IAggregateRoot
    {
    }
}
