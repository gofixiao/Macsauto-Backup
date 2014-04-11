using System;
using System.Collections.Generic;
using Macsauto.Domain.Accounting.Entities;
using Macsauto.Domain.Accounting.Entities.Journal;
using Macsauto.Domain.Accounting.Repositories;

namespace Macsauto.Domain.Accounting.Services
{
    public class JournalingService
    {
        private readonly Period _activePeriod;

        public JournalingService(IPeriodRepository periodRepository)
        {
            _activePeriod = periodRepository.GetActivePeriod();
        }

        public Branch CurrentBranch { get; set; }

        public JournalEntry PostSimpleEntry(string description, Account debitAccount, Account creditAccount, long amount, string reference = "")
        {
            if (CurrentBranch == null) throw new ApplicationException(@"Branch is not set");

            var journal = new JournalEntry(description, CurrentBranch, _activePeriod, reference);

            journal.JournalEntryItems.Add(new JournalEntryItem(debitAccount, JournalItemType.Debit, amount));
            journal.JournalEntryItems.Add(new JournalEntryItem(creditAccount, JournalItemType.Credit, amount));

            return journal;
        }

        public JournalEntry PostMultipleEntry(string description, IList<JournalEntryItem> debitEntries, IList<JournalEntryItem> creditEntries, string reference = "")
        {
            if (CurrentBranch == null) throw new ApplicationException(@"Branch is not set");

            var journal = new JournalEntry(description, CurrentBranch, _activePeriod, reference);

            foreach (var debitEntry in debitEntries)
            {
                journal.JournalEntryItems.Add(debitEntry);
            }

            foreach (var creditEntry in creditEntries)
            {
                journal.JournalEntryItems.Add(creditEntry);
            }

            if (!journal.IsBalanced()) throw new ApplicationException(@"Journal is imbalance.");

            return journal;
        }
    }
}