namespace Macsauto.Presentation.WinForm.ConfigurationModule.Inventory
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class AddPresenter
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IStorageRepository _storageRepository;
        private readonly IProductCategoryRepository _categoryRepository;
        private readonly IUnitOfMeasurementRepository _measurementRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMerchandiseRepository _merchandiseRepository;
        private readonly IStockMovementRepository _stockMovementRepository;
        private Add _form;

        public AddPresenter(IInventoryRepository inventoryRepository, IProductCategoryRepository categoryRepository, IStorageRepository storageRepository, IUnitOfMeasurementRepository measurementRepository, IProductRepository productRepository, IMerchandiseRepository merchandiseRepository, IStockMovementRepository stockMovementRepository)
        {
            _inventoryRepository = inventoryRepository;
            _categoryRepository = categoryRepository;
            _storageRepository = storageRepository;
            _measurementRepository = measurementRepository;
            _productRepository = productRepository;
            _merchandiseRepository = merchandiseRepository;
            _stockMovementRepository = stockMovementRepository;
        }

        public void SetForm(Add form)
        {
            _form = form;

            _form.UnitOfMeasurements = _measurementRepository.GetAll();
            _form.Storages = _storageRepository.GetAll();
            _form.ProductCategories = _categoryRepository.GetAll();
        }

        public Inventory Save()
        {
            Inventory inventory = null;
            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    inventory = _inventoryRepository.Insert(
                        new Inventory(
                            _form.Code, 
                            _form.InventoryName, 
                            _form.Description, 
                            _form.BuyPrice, 
                            _form.UnitOfMeasurement
                        )
                    );

                    if (_form.InventoryStorageDto.Count > 0)
                    {
                        var stockMovement = new StockMovement(
                            StockMovementType.INITIALBALANCE,
                            @"CREATED AUTOMATICALLY FROM ADD NEW INVENTORY");

                        foreach (var inventoryStorageDto in _form.InventoryStorageDto)
                        {
                            stockMovement.AddMovementItem(inventory, inventoryStorageDto.Storage, inventoryStorageDto.Quantity);

                            _storageRepository.Update(inventoryStorageDto.Storage);
                        }

                        _stockMovementRepository.Insert(stockMovement);
                    }

                    if (_form.AddAsProduct)
                    {
                        var product = new Product(
                            _form.ProductCode, 
                            inventory, 
                            _form.ProductCategory, 
                            _form.SellPrice
                        )
                            {
                                Volume = _form.Volume
                            };

                        _productRepository.Insert(product);
                    }

                    if (_form.AddAsMerchandise)
                    {
                        var merchandise = new Merchandise(
                            _form.MerchandiseCode, 
                            inventory, 
                            _form.MerchandisePoint,
                            1,
                            inventory.Name, 
                            inventory.Description
                        );

                        _merchandiseRepository.Insert(merchandise);
                    }
                });

            return inventory;
        }
    }
}