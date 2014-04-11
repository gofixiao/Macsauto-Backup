using System.Collections.Generic;
using Macsauto.Domain.Accounting.Entities;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain.Accounting.Repositories
{
    interface IAccountRepository : IRepository<Account>
    {
        IList<Account> GetAllInClassification(AccountClassification classification);
    }
}