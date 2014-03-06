namespace Macsauto.Domain.Shared
{
    public class PersonName : ValueObject<PersonName>
    {
        private string _firstname;
        private string _middlename = string.Empty;
        private string _lastname = string.Empty;

        protected PersonName()
        {
        }

        public PersonName(string firstname)
        {
            _firstname = firstname;
        }

        public PersonName(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }

        public PersonName(string firstname, string middlename, string lastname)
        {
            _firstname = firstname;
            _middlename = middlename;
            _lastname = lastname;
        }

        public virtual string Firstname
        {
            get { return _firstname; }
            protected set { _firstname = value; }
        }

        public virtual string Middlename
        {
            get { return _middlename; }
            protected set { _middlename = value; }
        }

        public virtual string Lastname
        {
            get { return _lastname; }
            protected set { _lastname = value; }
        }

        public virtual string Fullname
        {
            get
            {
                var fullname = _firstname;

                if (!string.IsNullOrEmpty(_middlename))
                {
                    fullname = _firstname + " " + _lastname + " " + _lastname;
                }
                else if (!string.IsNullOrEmpty(_lastname))
                {
                    fullname = _firstname + " " + _lastname;
                }

                return fullname;
            }
        }
    }
}