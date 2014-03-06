namespace Macsauto.Presentation.WinForm.ConfigurationModule.Inventory
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class QuickAddPresenter
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IUnitOfMeasurementRepository _measurementRepository;
        private QuickAdd _form;

        public QuickAddPresenter(IInventoryRepository inventoryRepository, IUnitOfMeasurementRepository measurementRepository)
        {
            _inventoryRepository = inventoryRepository;
            _measurementRepository = measurementRepository;
        }

        public void SetForm(QuickAdd form)
        {
            _form = form;
            _form.Measurements = _measurementRepository.GetAll();
        }

        public Inventory Save()
        {
            Inventory inventory = null;
            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    inventory = new Inventory(
                        _form.InventoryCode,
                        _form.InventoryName,
                        _form.InventoryDescription,
                        _form.InventoryBuyPrice,
                        _form.Measurement
                    );

                    inventory = _inventoryRepository.Insert(inventory);
                });

            return inventory;
        }
    }
}