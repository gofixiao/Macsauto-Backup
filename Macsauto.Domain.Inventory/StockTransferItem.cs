namespace Macsauto.Domain.Sales.Entities
{
    public class StockTransferItem : ValueObject<StockTransferItem>
    {
        private Storage _from;
        private Storage _to;
        private long _amount;
        private Inventory _inventory;

        public StockTransferItem(Inventory inventory, Storage from, Storage to, long amount)
        {
            _inventory = inventory;
            _from = from;
            _to = to;
            _amount = amount;
        }

        public virtual Inventory Inventory
        {
            get { return _inventory; }
            protected set { _inventory = value; }
        }

        public virtual Storage From
        {
            get { return _from; }
            protected set { _from = value; }
        }

        public virtual Storage To
        {
            get { return _to; }
            protected set { _to = value; }
        }

        public virtual long Amount
        {
            get { return _amount; }
            protected set { _amount = value; }
        }
    }
}