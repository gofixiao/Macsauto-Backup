using System;

namespace Macsauto.Domain.Sales.Entities
{
    public class Membership : Entity
    {
        private long _point;
        private DateTime _activeFrom;
        private DateTime _activeTo;
        private DateTime? _disactivatedOn;
        private string _disactivationReason;
        private DateTime? _reactivatedOn;
        private string _reactivationReason;

        public Membership()
        {
            _point = 0;
            _activeFrom = DateTime.Now;
            _activeTo = _activeFrom.Date.AddYears(1);
        }

        public virtual long Point
        {
            get { return _point; }
            protected set { _point = value; }
        }

        public virtual DateTime ActiveFrom
        {
            get { return _activeFrom; }
            protected set { _activeFrom = value; }
        }

        public virtual DateTime ActiveTo
        {
            get { return _activeTo; }
            protected set { _activeTo = value; }
        }

        public virtual DateTime? DisactivatedOn
        {
            get { return _disactivatedOn; }
            protected set { _disactivatedOn = value; }
        }

        public virtual string DisactivationReason
        {
            get { return _disactivationReason; }
            protected set { _disactivationReason = value; }
        }

        public virtual DateTime? ReactivatedOn
        {
            get { return _reactivatedOn; }
            set { _reactivatedOn = value; }
        }

        public virtual string ReactivationReason
        {
            get { return _reactivationReason; }
            set { _reactivationReason = value; }
        }

        public virtual bool IsActive
        {
            get 
            {
                return _disactivatedOn == null
                           ? IsExpired
                           : !IsDisactivated;
            }
        }

        public virtual bool IsExpired
        {
            get { return _activeTo > DateTime.Now; }
        }

        public virtual bool IsDisactivated
        {
            get
            {
                return _disactivatedOn != null 
                    && (_reactivatedOn != null || _reactivatedOn < _disactivatedOn);
            }
        }

        public virtual void Extend()
        {
            _activeFrom = DateTime.Now;
            _activeFrom = _activeFrom.AddYears(1);
        }

        public virtual void Expire()
        {
            Disactivate(@"MEMBERSHIP EXPIRED");
        }

        public virtual void Disactivate(string reason)
        {
            _disactivatedOn = DateTime.Now;
            _disactivationReason = reason;
        }

        public virtual void Reactivate(string reason)
        {
            _reactivatedOn = DateTime.Now;
            _reactivationReason = reason;
        }

        public virtual void AddPoint(long point = 1)
        {
            _point += point;
        }

        public virtual void UsePoint(long point = 1)
        {
            _point -= point;
        }
    }
}