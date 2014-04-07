using System;

namespace Macsauto.Domain
{
    /// <summary>
    /// Base class of all person type classes
    /// </summary>
    public abstract class Person : Entity
    {
        private PersonName _name;

        /// <summary>
        /// Constructor
        /// 
        /// Create a basic person
        /// </summary>
        /// <param name="name">Person's name</param>
        protected Person(PersonName name)
        {
            _name = name;
        }

        /// <summary>
        /// Person's name
        /// </summary>
        public virtual PersonName Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual DateTime? Birthdate { get; set; }

        public virtual Gender Gender { get; set; }
    }
}
