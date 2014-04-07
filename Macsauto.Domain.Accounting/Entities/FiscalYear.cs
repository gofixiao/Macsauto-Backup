using System;
using System.Globalization;

namespace Macsauto.Domain.Accounting.Entities
{
    public class FiscalYear : Domain.Entity
    {
        private string _name;
        private DateTime _startDate;
        private DateTime _endDate;
        private DateTime? _closedOn;

        public FiscalYear(string name, DateTime startDate)
        {
            _name = name;
            _startDate = startDate;
            _endDate = startDate.AddYears(1);
        }

        public FiscalYear(string name, DateTime startDate, DateTime endDate)
        {
            _name = name;
            _startDate = startDate;
            _endDate = endDate;
        }

        public new virtual string Code
        {
            get { return "FY" + _startDate.Year.ToString(CultureInfo.InvariantCulture); }
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
            _closedOn = DateTime.Now;
        }
    }
}