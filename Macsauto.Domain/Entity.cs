using System;

namespace Macsauto.Domain
{
    public abstract class Entity
    {
        private string _code;
        private DateTime _createdOn;
        private DateTime _updatedOn;

        #region Properties

        public virtual Guid Id { get; protected set; }

        public virtual string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public virtual DateTime CreatedOn
        {
            get { return _createdOn; }
            protected set { _createdOn = value; }
        }

        public virtual DateTime UpdatedOn
        {
            get { return _updatedOn; }
            protected set { _updatedOn = value; }
        }

        public virtual DateTime? RemovedOn { get; set; }

        public virtual Employee CreatedBy { get; set; }

        public virtual Employee UpdatedBy { get; set; }

        public virtual Employee RemovedBy { get; set; }

        #endregion

        #region Constructor

        protected Entity()
        {
            _createdOn = DateTime.Now;
            _updatedOn = DateTime.Now;
        }

        protected Entity(string code)
        {
            _code = code;
            _createdOn = DateTime.Now;
            _updatedOn = DateTime.Now;
        }

        #endregion

        #region Methods (Public)

        public virtual bool IsRemoved()
        {
            return RemovedOn != null;
        }

        public virtual bool IsTransient()
        {
            return Id == null;
        }

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
