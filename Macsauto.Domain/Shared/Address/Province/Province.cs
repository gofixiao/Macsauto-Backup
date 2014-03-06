namespace Macsauto.Domain.Shared
{
    using System.Collections.Generic;

    public class Province : Entity
    {
        private string _name;

        public new virtual int Id { get; protected set; }

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