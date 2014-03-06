using System;
using Macsauto.Domain.UserManagementModule;

namespace Macsauto.Domain.Shared
{
    public abstract class Entity
    {
        #region Members

        //ReSharper disable InconsistentNaming

        protected Guid? _id;
        protected DateTime _createdOn;
        protected DateTime? _updatedOn;
        protected string _code;

        //Resharper resume InconsistentNaming

        #endregion

        #region Properties

        public virtual Guid? Id
        {
            get { return _id; }
            protected set { _id = value; }
        }

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

        public virtual DateTime? UpdatedOn
        {
            get { return _updatedOn; }
            set { _updatedOn = value; }
        }

        public virtual Employee CreatedBy { get; set; }

        public virtual Employee UpdatedBy { get; set; }

        #endregion

        #region Constructor

        protected Entity()
        {
            _createdOn = DateTime.Now;
        }

        #endregion

        #region Methods (Public)

        public virtual bool IsTransient()
        {
            return _id == null;
        }

        public virtual void GenerateNewGuidId()
        {
            if (!IsTransient())
            {
                throw new ApplicationException("Cannot assign new id to non-transient entity");
            }

            _id = Guid.NewGuid();
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
