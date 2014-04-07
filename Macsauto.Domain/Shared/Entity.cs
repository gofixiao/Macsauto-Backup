using System;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain.Shared
{
    using Macsauto.Domain.UserManagementModule;

    /// <summary>
    /// Base entity
    /// All class that has an id and a code must be inherited from this.
    /// </summary>
    public abstract class Entity
    {
        private string _code;
        private DateTime _createdOn;
        private DateTime _updatedOn;

        #region Properties

        /// <summary>
        /// Entity's primary ID
        /// </summary>
        public virtual Guid Id { get; protected set; }

        /// <summary>
        /// A human readable ID
        /// </summary>
        public virtual string Code
        {
            get { return _code; }
            protected set { _code = value; }
        }

        /// <summary>
        /// Entity creation timestamp
        /// </summary>
        public virtual DateTime CreatedOn
        {
            get { return _createdOn; }
            protected set { _createdOn = value; }
        }

        /// <summary>
        /// Entity last update timestamp
        /// </summary>
        public virtual DateTime UpdatedOn
        {
            get { return _updatedOn; }
            protected set { _updatedOn = value; }
        }

        /// <summary>
        /// Entity deletion timestamp
        /// </summary>
        public virtual DateTime? RemovedOn { get; set; }

        /// <summary>
        /// Entity creator
        /// </summary>
        public virtual Employee CreatedBy { get; set; }

        /// <summary>
        /// Entity updater
        /// </summary>
        public virtual Employee UpdatedBy { get; set; }

        /// <summary>
        /// Entity remover
        /// </summary>
        public virtual Employee RemovedBy { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Base constructor
        /// </summary>
        protected Entity(string code)
        {
            _code = code;
            _createdOn = DateTime.Now;
            _updatedOn = DateTime.Now;
        }

        #endregion

        #region Methods (Public)

        /// <summary>
        /// Check whether the entity has been removed
        /// </summary>
        /// <returns>True if entity is removed, otherwise false</returns>
        public virtual bool IsRemoved()
        {
            return RemovedOn != null;
        }

        /// <summary>
        /// Check whether the entity has an ID assigned
        /// </summary>
        /// <returns>True if entity has an ID, otherwise false</returns>
        public virtual bool IsTransient()
        {
            return Id == null;
        }
        
        /// <summary>
        /// Mark an entity as removed
        /// </summary>
        /// <returns>The removed entity</returns>
        public virtual Entity Delete()
        {
            RemovedOn = DateTime.Now;

            return this;
        }

        #endregion

        #region Methods (Overrides)

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Entity)) return false;

            var entity = obj as Entity;

            if (entity.IsTransient() || IsTransient())
            {
                return ReferenceEquals(entity, this);
            }

            return entity.Id == Id;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return GetType().GetHashCode();
            }
        }

        public static bool operator ==(Entity left, Entity right)
        {
            if (Equals(left, null))
            {
                return Equals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }

        #endregion
    }
}
