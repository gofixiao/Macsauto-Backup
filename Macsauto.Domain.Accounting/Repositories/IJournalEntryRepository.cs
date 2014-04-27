using System;
using System.Collections.Generic;
using Macsauto.Domain.Accounting.Entities;
using Macsauto.Domain.Accounting.Entities.Journal;

namespace Macsauto.Domain.Accounting.Repositories
{
    interface IJournalEntryRepository : IRepository<JournalEntry, Guid>
    {
        IList<JournalEntry> GetAllInPeriod(Period period);
        IList<JournalEntry> GetAllInFiscalYear(FiscalYear fiscalYear);
        IList<JournalEntry> GetAllBetween(DateTime startDate, DateTime endDate);
    }
}