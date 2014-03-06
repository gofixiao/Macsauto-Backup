namespace Macsauto.Presentation.WinForm.ManagementModule.Merchandise
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class AddFromInventoryPresenter
    {
        private readonly IMerchandiseRepository _merchandiseRepository;
        private readonly IInventoryRepository _inventoryRepository;
        private AddFromInventory _form;

        public AddFromInventoryPresenter(IMerchandiseRepository merchandiseRepository, IInventoryRepository inventoryRepository)
        {
            _merchandiseRepository = merchandiseRepository;
            _inventoryRepository = inventoryRepository;
        }

        public void SetForm(AddFromInventory form)
        {
            _form = form;

            _form.Inventories = _inventoryRepository.GetAll();
        }

        public Merchandise Save()
        {
            Merchandise merchandise = null;

            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
            {
                merchandise = new Merchandise(
                    _form.MerchandiseCode,
                    _form.SelectedInventory,
                    _form.MerchandisePointCost,
                    _form.MerchandiseVolume,
                    _form.MerchandiseName,
                    _form.MerchandiseDescription
                );

                merchandise = _merchandiseRepository.Insert(merchandise);
            });

            return merchandise;
        }
    }
}