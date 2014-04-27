using System;
using System.Collections.Generic;
using Macsauto.Domain.Accounting.Entities;

namespace Macsauto.Domain.Accounting.Repositories
{
    interface IAccountRepository : IRepository<Account, Guid>
    {
        IList<Account> GetAllInClassification(AccountClassification classification);
    }
}