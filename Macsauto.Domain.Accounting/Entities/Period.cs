using System;
using System.Linq;
using Macsauto.Domain.Accounting.Repositories;

namespace Macsauto.Domain.Accounting.Entities
{
    public class Period : Domain.Entity
    {
        private readonly IPeriodRepository _repo;
        private string _name;
        private FiscalYear _fiscalYear;
        private DateTime _startDate;
        private DateTime _endDate;

        public Period(string name, FiscalYear fiscalYear, DateTime startDate, DateTime endDate, IPeriodRepository repo)
        {
            bool anyOverlappingPeriod = _repo.GetAllInFiscalYear(fiscalYear)
                                             .Any(x => startDate > x.EndDate && endDate < x.EndDate);
            bool isNotInFiscalYear = startDate < fiscalYear.StartDate || endDate > fiscalYear.EndDate;

            if (fiscalYear.IsClosed)
                throw new ApplicationException(@"Fiscal year " + fiscalYear.Code + " is closed");

            if (anyOverlappingPeriod || isNotInFiscalYear)
                throw new ApplicationException(@"The period is invalid. Either some periods are overlapping or the period's dates are not matching the scope of the fiscal year.");

            _name = name;
            _fiscalYear = fiscalYear;
            _repo = repo;
            _startDate = startDate;
            _endDate = endDate;
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