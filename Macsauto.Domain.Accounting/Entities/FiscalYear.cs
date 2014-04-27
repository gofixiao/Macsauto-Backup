using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Macsauto.Domain.Accounting.Entities
{
    public class FiscalYear : Entity<FiscalYear, Guid>, IAggregateRoot
    {
        private string _name;
        private DateTime _startDate;
        private DateTime _endDate;
        private DateTime? _closedOn;
        private string _closingReason;
        private IList<Period> _registeredPeriods; 

        protected FiscalYear(string code, string name, DateTime startDate, DateTime endDate) : base(code)
        {
            _name = name;
            _startDate = startDate;
            _endDate = endDate;
            _registeredPeriods = new List<Period>();
        }

        public static FiscalYear NewSingleFiscalYear(string name, DateTime startDate)
        {
            var code = "FY" + startDate.Year.ToString(CultureInfo.InvariantCulture);

            return new FiscalYear(code, name, startDate, startDate.AddYears(1));
        }

        public static FiscalYear NewPeriodicFiscalYear(string name, DateTime startDate, DateTime endDate)
        {
            var code = "FY" + startDate.Year.ToString(CultureInfo.InvariantCulture);

            return new FiscalYear(code, name, startDate, endDate);
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual DateTime StartDate
        {
            get { return _startDate; }
            protected set { _startDate = value; }
        }

        public virtual DateTime EndDate
        {
            get { return _endDate; }
            protected set { _endDate = value; }
        }

        public virtual DateTime? ClosedOn
        {
            get { return _closedOn; }
            protected set { _closedOn = value; }
        }

        public virtual string ClosingReason
        {
            get { return _closingReason; }
            set { _closingReason = value; }
        }

        public virtual IList<Period> RegisteredPeriod
        {
            get { return _registeredPeriods; }
            protected set { _registeredPeriods = value; }
        }

        public bool IsPeriodOverlaps(DateTime startDate, DateTime endDate)
        {
            return _registeredPeriods.Any(x => startDate > x.EndDate && endDate < x.EndDate);
        }

        public virtual bool IsOpen
        {
            get { return _closedOn == null; }
        }

        public virtual bool IsClosed
        {
            get { return !IsOpen; }
        }

        public void Close()
        {
            if (IsClosed) throw new ApplicationException(@"Fiscal year is already closed.");

            if (DateTime.Now < _endDate) throw new ApplicationException(@"Fiscal year period is not over.");

            _closedOn = DateTime.Now;
            _closingReason = @"Period is finished";
        }

        public void ForceClose(string reason)
        {
            if (IsClosed) throw new Exception(@"Fiscal year is already closed.");

            _closedOn = DateTime.Now;
            _closingReason = reason;
        }
    }
}