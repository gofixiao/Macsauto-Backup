namespace Macsauto.Presentation.WinForm.ManagementModule.Product
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class AddFromInventoryPresenter
    {
        private readonly IProductRepository _productRepository;
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IProductCategoryRepository _productCategoryRepository;
        private AddFromInventory _form;

        public AddFromInventoryPresenter(IProductRepository productRepository, IInventoryRepository inventoryRepository, IProductCategoryRepository productCategoryRepository)
        {
            _productRepository = productRepository;
            _inventoryRepository = inventoryRepository;
            _productCategoryRepository = productCategoryRepository;
        }

        public void SetForm(AddFromInventory form)
        {
            _form = form;

            _form.ProductCategories = _productCategoryRepository.GetAll();
            _form.Inventories = _inventoryRepository.GetAll();
        }

        public Product Save()
        {
            Product product = null;

            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    product = new Product(
                        _form.ProductCode,
                        _form.SelectedInventory,
                        _form.SelectedCategory,
                        _form.ProductSellPrice
                    )
                        {
                            Name = _form.SelectedProductName,
                            Description = _form.ProductDescription,
                            Volume = _form.Volume
                        };

                    product = _productRepository.Insert(product);
                });

            return product;
        }
    }
}