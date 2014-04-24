using System;
using System.Collections.Generic;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain.Sales.Entities
{
    public class StockTransfer : Entity
    {
        private string _referenceDocument;
        private string _movementRemark;
        private IList<StockTransferItem> _stockTransferItems;

        public StockTransfer(string movementRemark, string referenceDocument = null)
        {
            _movementRemark = movementRemark;
            _referenceDocument = referenceDocument;
            _stockTransferItems = new List<StockTransferItem>();
        }

        public virtual string ReferenceDocument
        {
            get { return _referenceDocument; }
            protected set { _referenceDocument = value; }
        }

        public virtual string MovementRemark
        {
            get { return _movementRemark; }
            protected set { _movementRemark = value; }
        }

        public virtual IList<StockTransferItem> StockTransferItems
        {
            get { return _stockTransferItems; }
            protected set { _stockTransferItems = value; }
        }

        public void AddTransferItem(Storage from, Storage to, Inventory inventory, long quantity)
        {
            if (from.GetStockOf(inventory) < quantity)
            {
                throw new ApplicationException(string.Format(@"Not enough {0} stock stored in {1}", inventory.Name, from.Name));
            }

            from.Take(inventory, quantity);
            to.Store(inventory, quantity);

            _stockTransferItems.Add(new StockTransferItem(inventory, from, to, quantity));
        }
    }
}