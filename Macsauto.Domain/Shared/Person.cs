namespace Macsauto.Domain.Shared
{
    using System;

    public abstract class Person : Entity
    {
        private PersonName _name;

        protected Person() { }

        protected Person(PersonName name)
        {
            _name = name;
        }

        public virtual PersonName Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual DateTime? Birthdate { get; set; }

        public virtual Gender Gender { get; set; }
    }
}
