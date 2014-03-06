using Macsauto.Domain.SalesModule;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Inventory
{
    public class ViewPresenter
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IStorageRepository _storageRepository;
        private View _form;

        public ViewPresenter(IInventoryRepository inventoryRepository, IStorageRepository storageRepository)
        {
            _inventoryRepository = inventoryRepository;
            _storageRepository = storageRepository;
        }

        public void SetForm(View form)
        {
            _form = form;

            _form.Inventories = _inventoryRepository.GetAll();
        }

        public void GetInventoryStocks()
        {
            var inventory = _form.SelectedInventory;

            if (inventory != null)
            {
                _form.Storages = _storageRepository.GetStoragesWithInventory(inventory);
            }
        }
    }
}