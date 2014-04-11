using System.Collections.Generic;
using Macsauto.Domain.Accounting.Entities;

namespace Macsauto.Domain.Accounting.Repositories
{
    public interface IPeriodRepository
    {
        Period GetActivePeriod();
        IList<Period> GetAllInFiscalYear(FiscalYear fiscalYear); 
    }
}