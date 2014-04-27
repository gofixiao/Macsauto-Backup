using System;

namespace Macsauto.Domain.Core.Entities.Location
{
    public class Province : Entity<Province, Guid>, IAggregateRoot
    {
        private string _name;

        public virtual string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public Province(string name)
        {
            _name = name;
        }

        protected Province(){}

        public override string ToString()
        {
            return _name;
        }
    }
}