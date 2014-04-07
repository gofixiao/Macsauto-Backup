namespace Macsauto.Domain.Sales.Inventory.StockMovement
{
    public class StockMovementItem : ValueObject<StockMovementItem>
    {
        private StockMovement _stockMovement;
        private Inventory _inventory;
        private Storage.Storage _storage;
        private long _quantity;
        private long _previousStock;
        private long _currentStock;

        protected StockMovementItem(){}

        public StockMovementItem(StockMovement stockMovement, Inventory inventory, Storage.Storage storage, long quantity)
        {
            _stockMovement = stockMovement;
            _inventory = inventory;
            _storage = storage;
            _quantity = quantity;
            _previousStock = _storage.GetStockOf(inventory);

            if (_stockMovement.Type == StockMovementType.IN || 
                _stockMovement.Type == StockMovementType.INITIALBALANCE)
            {
                _storage.Store(inventory, quantity);
                _currentStock = _previousStock + _quantity;
            }
            else
            {
                _storage.Take(inventory, quantity);
                _currentStock = _previousStock - _quantity;
            }
        }

        public virtual StockMovement StockMovement
        {
            get { return _stockMovement; }
            protected set { _stockMovement = value; }
        }

        public virtual Inventory Inventory
        {
            get { return _inventory; }
            protected set { _inventory = value; }
        }

        public virtual Storage.Storage Storage
        {
            get { return _storage; } 
            protected set { _storage = value; }
        }

        public virtual long PreviousStock
        {
            get { return _previousStock; }
            protected set { _previousStock = value; }
        }

        public virtual long CurrentStock
        {
            get { return _currentStock; }
            protected set { _currentStock = value; }
        }

        public virtual long Quantity
        {
            get { return _quantity; }
            protected set { _quantity = value; }
        }
    }
}