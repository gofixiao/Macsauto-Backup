namespace Macsauto.Domain.Sales.Entities
{
    public class StoredInventory : ValueObject<StoredInventory>
    {
        private Inventory _inventory;
        private long _stock;
        private Storage _storage;

        public StoredInventory(Storage storage, Inventory inventory, long stock)
        {
            _storage = storage;
            _inventory = inventory;
            _stock = stock;
        }

        public virtual Inventory Inventory
        {
            get { return _inventory; }
            protected set { _inventory = value; }
        }

        public virtual Storage Storage
        {
            get { return _storage; }
            protected set { _storage = value; }
        }

        public virtual long Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}