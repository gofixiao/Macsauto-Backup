using System;

namespace Macsauto.Domain.Sales.Promotion
{
    public abstract class Promotion : Entity
    {
        private DateTime _applicableFrom = DateTime.Now;
        private DateTime _applicableTo = DateTime.Now.AddMonths(1);

        protected Promotion()
        {
        }

        protected Promotion(DateTime applicableFrom, DateTime applicableTo)
        {
            _applicableFrom = applicableFrom;
            _applicableTo = applicableTo;
        }

        public virtual DateTime ApplicableFrom
        {
            get { return _applicableFrom; }
            protected set { _applicableFrom = value; }
        }

        public virtual DateTime ApplicableTo
        {
            get { return _applicableTo; }
            protected set { _applicableTo = value; }
        }
    }
}