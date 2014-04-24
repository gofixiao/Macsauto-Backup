using System;
using System.Collections.Generic;
using System.Linq;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain.Sales.Entities
{
    public class Storage : Entity
    {
        private string _name;
        private string _description;
        private IList<StoredInventory> _storedInventories;

        public Storage(string code, string name, string description)
        {
            _name = name;
            _description = description;
            _storedInventories = new List<StoredInventory>();
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

        public virtual IList<StoredInventory> StoredInventories
        {
            get { return _storedInventories; }
            protected set { _storedInventories = value; }
        }

        public virtual void Store(Inventory inventory, long quantity)
        {
            var storedInventory = _storedInventories.FirstOrDefault(x => x.Inventory.Id == inventory.Id);

            if (storedInventory != null)
            {
                storedInventory.Stock += quantity;
            }
            else
            {
                _storedInventories.Add(new StoredInventory(this, inventory, quantity));
            }
        }

        public virtual void Take(Inventory inventory, long quantity)
        {
            var storedInventory = _storedInventories.First(x => x.Inventory.Id == inventory.Id);

            if (storedInventory == null || storedInventory.Stock < quantity)
            {
                throw new ApplicationException(string.Format(@"Not enough {0} stock stored in {1}", inventory.Name, Name));
            }

            storedInventory.Stock -= quantity;
        }

        public virtual long GetStockOf(Inventory inventory)
        {
            var storedInventory = _storedInventories.FirstOrDefault(x => x.Inventory.Id == inventory.Id);

            return storedInventory == null ? 0 : storedInventory.Stock;
        }
    }
}