namespace Macsauto.Presentation.WinForm.ConfigurationModule.ProductCategory
{
    using Macsauto.Domain.SalesModule;

    public class ViewPresenter
    {
        private readonly IProductCategoryRepository _categoryRepository;
        private View _form;

        public ViewPresenter(IProductCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void SetForm(View form)
        {
            _form = form;
            _form.ProductCategories = _categoryRepository.GetAll();
        }
    }
}