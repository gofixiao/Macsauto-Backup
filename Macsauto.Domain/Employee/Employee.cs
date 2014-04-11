namespace Macsauto.Domain
{
    public class Employee : Person
    {
        private Branch _branch;
        private Position _position;

        public Employee(Branch branch, Position position, PersonName name, Gender gender) : base(name)
        {
            _branch = branch;
            _position = position;
            base.Gender = gender;
        }

        public virtual Branch Branch
        {
            get { return _branch; }
            set { _branch = value; }
        }

        public virtual Position Position
        {
            get { return _position; }
            protected set { _position = value; }
        }

        public virtual string CellPhone { get; set; }

        public virtual string Email { get; set; }

        public virtual Address HomeAddress { get; set; }
    }
}