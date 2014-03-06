using Macsauto.Domain.Shared;

namespace Macsauto.Domain.SalesModule
{
    public class UnitOfMeasurement : Entity
    {
        private string _description;

        protected UnitOfMeasurement()
        {
        }

        public UnitOfMeasurement(string name, string description)
        {
            _code = name;
            _description = description;
        }

        public virtual string Name
        {
            get { return _code; }
            protected set
            {
                _code = value;
            }
        }

        public virtual string Description
        {
            get { return _description; }
            protected set { _description = value; }
        }
    }
}
