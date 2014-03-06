namespace Macsauto.Presentation.WinForm.ManagementModule.Merchandise
{
    using System.Linq;
    using Macsauto.Domain.SalesModule;

    public class ViewPresenter
    {
        private readonly IMerchandiseRepository _merchandiseRepository;
        private readonly IStorageRepository _storageRepository;
        private View _form;

        public ViewPresenter(IMerchandiseRepository merchandiseRepository, IStorageRepository storageRepository)
        {
            _merchandiseRepository = merchandiseRepository;
            _storageRepository = storageRepository;
        }

        public void SetForm(View form)
        {
            _form = form;

            _form.Merchandises = _merchandiseRepository.GetAll();
        }

        public long GetTotalStock(Inventory inventory)
        {
            var storages = _storageRepository.GetStoragesWithInventory(inventory);

            return storages.Sum(x => x.GetStockOf(inventory));
        }
    }
}