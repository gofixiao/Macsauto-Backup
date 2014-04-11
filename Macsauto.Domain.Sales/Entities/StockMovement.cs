using System;
using System.Collections.Generic;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain.Sales.Entities
{
    public class StockMovement : Entity
    {
        private StockMovementType _type;
        private string _reference;
        private string _remark;
        private IList<StockMovementItem> _stockMovementItems;

        public StockMovement(StockMovementType type)
        {
            _type = type;
            _stockMovementItems = new List<StockMovementItem>();
        }

        public StockMovement(StockMovementType type, string remark)
        {
            _type = type;
            _remark = remark;
            _stockMovementItems = new List<StockMovementItem>();
        }

        public StockMovement(StockMovementType type, string remark, string reference)
        {
            _type = type;
            _remark = remark;
            _reference = reference;
            _stockMovementItems = new List<StockMovementItem>();
        }

        public virtual StockMovementType Type
        {
            get { return _type; }
            protected set { _type = value; }
        }

        public virtual string Reference
        {
            get { return _reference; }
            protected set { _reference = value; }
        }

        public virtual string Remark
        {
            get { return _remark; }
            protected set { _remark = value; }
        }

        public virtual IList<StockMovementItem> StockMovementItems
        {
            get { return _stockMovementItems; }
            protected set { _stockMovementItems = value; }
        }

        public virtual void AddMovementItem(Inventory inventory, Storage storage, long quantity)
        {
            foreach (var stockMovementItem in _stockMovementItems)
            {
                if (stockMovementItem.Inventory == inventory)
                {
                    var tempQty = stockMovementItem.Quantity;

                    _stockMovementItems.Remove(stockMovementItem);

                    quantity += tempQty;
                }
            }

            _stockMovementItems.Add(new StockMovementItem(this, inventory, storage, quantity));
        }
    }
}