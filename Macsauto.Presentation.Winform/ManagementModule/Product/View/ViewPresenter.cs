using System.Linq;

namespace Macsauto.Presentation.WinForm.ManagementModule.Product
{
    using Macsauto.Domain.SalesModule;

    public class ViewPresenter
    {
        private readonly IProductRepository _productRepository;
        private readonly IStorageRepository _storageRepository;
        private View _form;

        public ViewPresenter(IProductRepository productRepository, IStorageRepository storageRepository)
        {
            _productRepository = productRepository;
            _storageRepository = storageRepository;
        }

        public void SetForm(View form)
        {
            _form = form;

            _form.Products = _productRepository.GetAll();
        }

        public long GetTotalStock(Inventory inventory)
        {
            var storages = _storageRepository.GetStoragesWithInventory(inventory);

            return storages.Sum(x => x.GetStockOf(inventory));
        }
    }
}