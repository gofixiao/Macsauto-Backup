using System;
using System.Collections.Generic;
using Macsauto.Domain.Accounting.Entities;
using Macsauto.Domain.Accounting.Entities.Journal;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain.Accounting.Repositories
{
    interface IJournalEntryRepository : IRepository<JournalEntry>
    {
        IList<JournalEntry> GetAllInPeriod(Period period);
        IList<JournalEntry> GetAllInFiscalYear(FiscalYear fiscalYear);
        IList<JournalEntry> GetAllBetween(DateTime startDate, DateTime endDate);
    }
}