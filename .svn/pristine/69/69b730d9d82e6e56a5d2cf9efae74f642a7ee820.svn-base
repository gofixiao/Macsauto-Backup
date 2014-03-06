namespace Macsauto.Domain.UserManagementModule
{
    using Macsauto.Domain.Shared;

    public class Terminal : Entity
    {
        private string _macAddress;
        private Branch _branch;

        protected Terminal(){}

        public Terminal(string code, string macAddress, Branch branch)
        {
            _code = code;
            _macAddress = macAddress;
            _branch = branch;
        }

        public virtual string MacAddress
        {
            get { return _macAddress; }
            protected set { _macAddress = value; }
        }

        public virtual Branch Branch
        {
            get { return _branch; }
            protected set { _branch = value; }
        }
    }
}