using System;

namespace Macsauto.Domain.Accounting.Entities
{
    public class Period : Entity<Period, Guid>
    {
        private string _name;
        private FiscalYear _fiscalYear;
        private DateTime _startDate;
        private DateTime _endDate;

        public Period(string name, FiscalYear fiscalYear, DateTime startDate, DateTime endDate)
        {
            bool isNotInFiscalYear = startDate < fiscalYear.StartDate || endDate > fiscalYear.EndDate;

            if (fiscalYear.IsClosed)
                throw new ApplicationException(@"Fiscal year " + fiscalYear.Code + " is closed");

            if (_fiscalYear.IsPeriodOverlaps(startDate, endDate) || isNotInFiscalYear)
                throw new ApplicationException(@"The period is invalid. Either some periods are overlapping or the period's dates are not matching the scope of the fiscal year.");

            _name = name;
            _fiscalYear = fiscalYear;
            _startDate = startDate;
            _endDate = endDate;

            _fiscalYear.RegisteredPeriod.Add(this);
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual FiscalYear FiscalYear
        {
            get { return _fiscalYear; }
            protected set { _fiscalYear = value; }
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
    }
}