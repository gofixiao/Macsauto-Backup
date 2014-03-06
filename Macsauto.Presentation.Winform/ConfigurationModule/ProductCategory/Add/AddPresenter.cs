namespace Macsauto.Presentation.WinForm.ConfigurationModule.ProductCategory
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class AddPresenter
    {
        private readonly IProductCategoryRepository _categoryRepository;
        private Add _form;

        public AddPresenter(IProductCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void SetForm(Add form)
        {
            _form = form;
        }

        public ProductCategory Save()
        {
            ProductCategory productCategory = null;
            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    productCategory = new ProductCategory(_form.Code, _form.CategoryName, _form.CategoryDescription);

                    productCategory = _categoryRepository.Insert(productCategory);
                });

            return productCategory;
        }
    }
}