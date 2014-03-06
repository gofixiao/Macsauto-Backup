namespace Macsauto.Domain.AccountingModule
{
    using Macsauto.Domain.Shared;

    public class JournalEntryItem : ValueObject<JournalEntryItem>
    {
        private Account _account;
        private JournalItemType _type;
        private long _amount;

        public JournalEntryItem(Account account, JournalItemType type, long amount)
        {
            _account = account;
            _type = type;
            _amount = amount;
        }

        public virtual Account Account
        {
            get { return _account; }
            protected set { _account = value; }
        }

        public virtual JournalItemType Type
        {
            get { return _type; }
            protected set { _type = value; }
        }

        public virtual long Amount

        {
            get { return _amount; }
            protected set { _amount = value; }
        }
    }

    public enum JournalItemType
    {
// ReSharper disable InconsistentNaming
        DEBIT, CREDIT
// ReSharper restore InconsistentNaming
    }
}