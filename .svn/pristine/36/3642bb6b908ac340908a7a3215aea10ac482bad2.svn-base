namespace Macsauto.Domain.AccountingModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Macsauto.Domain.Shared;
    using Macsauto.Domain.UserManagementModule;

    public class JournalEntry : Entity
    {
        private string _description;
        private Branch _branch;
        private string _reference;
        private IList<JournalEntryItem> _journalEntryItems;
        private DateTime _postDate;
        private Period _period;

        public JournalEntry(string description, Branch branch, Period period, string reference = "")
        {
            _description = description;
            _branch = branch;
            _reference = reference;
            _period = period;
            _journalEntryItems = new List<JournalEntryItem>();
        }

        public JournalEntry(string description, Branch branch, Period period, bool postNow = true, string reference = "")
        {
            _description = description;
            _branch = branch;
            _period = period;
            _reference = reference;
            _journalEntryItems = new List<JournalEntryItem>();

            if (postNow)
            {
                _postDate = DateTime.Now;
            }
        }

        public virtual string Description
        {
            get { return _description; }
            protected set { _description = value; }
        }

        public virtual Branch Branch
        {
            get { return _branch; }
            protected set { _branch = value; }
        }

        public virtual string Reference
        {
            get { return _reference; }
            protected set { _reference = value; }
        }

        public virtual Period Period
        {
            get { return _period; }
            protected set { _period = value; }
        }

        public virtual IList<JournalEntryItem> JournalEntryItems
        {
            get { return _journalEntryItems; }
            protected set { _journalEntryItems = value; }
        }

        public virtual DateTime PostDate
        {
            get { return _postDate; }
            protected set { _postDate = value; }
        }

        public bool IsBalanced()
        {
            if (_journalEntryItems == null)
            {
                return false;
            }

            var debit = _journalEntryItems
                .Where(x => x.Type == JournalItemType.DEBIT)
                .Sum(x => x.Amount);

            var credit = _journalEntryItems
                .Where(x => x.Type == JournalItemType.CREDIT)
                .Sum(x => x.Amount);

            return debit == credit;
        }
    }
}