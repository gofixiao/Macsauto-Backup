using System;

namespace Macsauto.Domain.BranchManagement.Entities
{
    public class Terminal : Entity<Terminal, Guid>
    {
        private string _macAddress;
        private Branch _branch;

        protected Terminal(){}

        public Terminal(string macAddress, Branch branch)
        {
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