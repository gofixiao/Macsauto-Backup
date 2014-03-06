using Macsauto.Domain.Shared;

namespace Macsauto.Domain.SalesModule
{
    public class Inventory : Entity
    {
        private string _name;
        private string _description;
        private UnitOfMeasurement _uoM;
        private long _buyPrice;

        protected Inventory()
        {
        }

        public Inventory(string code, string name, string description, long buyPrice, UnitOfMeasurement uoM)
        {
            _code = code;
            _name = name;
            _buyPrice = buyPrice;
            _description = description;
            _uoM = uoM;
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public virtual UnitOfMeasurement UoM
        {
            get { return _uoM; }
            set { _uoM = value; }
        }

        public virtual long BuyPrice
        {
            get { return _buyPrice; }
            set { _buyPrice = value; }
        }
    }
}