namespace Macsauto.Domain.Accounting.Entities
{
    public class Account : Entity
    {
        private string _name;
        private string _description;
        private Account _parent;
        private AccountClassification _classification;
        private long _debit;
        private long _credit;
        
        public Account(string name, AccountClassification classification, string description = "")
        {
            _name = name;
            _classification = classification;
            _description = description;
        }

        public Account(string name, AccountClassification classification, long debit, long credit, string description = "")
        {
            _name = name;
            _classification = classification;
            _debit = debit;
            _credit = credit;
            _description = description;
        }

        public Account(string name, AccountClassification classification, long debit, long credit, Account parent, string description = "")
        {
            _name = name;
            _classification = classification;
            _debit = debit;
            _credit = credit;
            _parent = parent;
            _description = description;
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public virtual Account Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        public virtual AccountClassification Classification
        {
            get { return _classification; }
            set { _classification = value; }
        }

        public virtual long Debit
        {
            get { return _debit; }
            set { _debit = value; }
        }

        public virtual long Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }

        public virtual long Balance
        {
            get { return _debit - _credit; }
        }
    }
}