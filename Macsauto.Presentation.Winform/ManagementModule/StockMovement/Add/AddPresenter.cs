using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping;

namespace Macsauto.Presentation.WinForm.ManagementModule.StockMovement
{
    using System;
    using System.Globalization;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class AddPresenter
    {
        private readonly IStockMovementRepository _movementRepository;
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IStorageRepository _storageRepository;
        private Add _form;

        public AddPresenter(IStockMovementRepository movementRepository, IInventoryRepository inventoryRepository, IStorageRepository storageRepository)
        {
            _movementRepository = movementRepository;
            _inventoryRepository = inventoryRepository;
            _storageRepository = storageRepository;
        }

        public void SetForm(Add form)
        {
            _form = form;

            _form.Storages = _storageRepository.GetAll();
        }

        public void GetInventories(Storage storage)
        {
            var inventories = storage.StoredInventories.Select(storedInventory => storedInventory.Inventory).ToList();

            _form.Inventories = inventories;
        }

        public StockMovement Save()
        {
            StockMovement stockMovement = null;

            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
            {
                stockMovement = new StockMovement(
                    _form.StockMovementType,
                    _form.MovementRemark,
                    _form.MovementReference
                );

                foreach (var dto in _form.StockMovementItemDtos)
                {
                    stockMovement.AddMovementItem(dto.Inventory, dto.Storage, dto.Quantity);
                }

                stockMovement = _movementRepository.Insert(stockMovement);
            });

            return stockMovement;
        }
    }
}