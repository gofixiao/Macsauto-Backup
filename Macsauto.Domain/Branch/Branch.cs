namespace Macsauto.Domain
{
    public class Branch : Entity
    {
        private string _name;
        private Address _address;

        public Branch(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public virtual string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public virtual Address Address
        {
            get { return _address; }
            protected set { _address = value; }
        }
    }
}