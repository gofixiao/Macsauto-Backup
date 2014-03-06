namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Shared;

    public class Product : Entity
    {
        private Inventory _inventory;
        private ProductCategory _category;
        private long _volume;
        private long _sellPrice;
        private string _name;
        private string _description;

        protected Product()
        {
        }

        public Product(string code, Inventory inventory, ProductCategory category, long sellPrice)
        {
            _code = code;
            _inventory = inventory;
            _category = category;
            _volume = 1;
            _sellPrice = sellPrice;
            _name = _inventory.Name;
            _description = _inventory.Description;
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

        public virtual Inventory Inventory
        {
            get { return _inventory; }
            protected set { _inventory = value; }
        }

        public virtual ProductCategory Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public virtual long Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public virtual long SellPrice
        {
            get { return _sellPrice; }
            set { _sellPrice = value; }
        }
    }
}