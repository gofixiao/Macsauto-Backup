namespace Macsauto.Domain.Sales.Entities
{
    public class Merchandise : Entity
    {
        private Inventory _inventory;
        private long _pointCost;
        private string _name;
        private string _description;
        private long _volume;

        protected Merchandise()
        {
        }

        public Merchandise(string code, Inventory inventory, long pointCost, long volume)
        {
            _code = code;
            _inventory = inventory;
            _pointCost = pointCost;
            _volume = volume;
            _name = _inventory.Name;
            _description = _inventory.Description;
        }

        public Merchandise(string code, Inventory inventory, long pointCost, long volume, string name, string description)
        {
            _code = code;
            _inventory = inventory;
            _pointCost = pointCost;
            _volume = volume;
            _name = name;
            _description = description;
        }

        public virtual Inventory Inventory
        {
            get { return _inventory; }
            protected set { _inventory = value; }
        }

        public virtual long PointCost
        {
            get { return _pointCost; }
            set { _pointCost = value; }
        }

        public virtual long Volume
        {
            get { return _volume; }
            set { _volume = value; }
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
    }
}