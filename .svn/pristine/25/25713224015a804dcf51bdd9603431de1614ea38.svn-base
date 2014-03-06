namespace Macsauto.Presentation.WinForm.ConfigurationModule.ServiceCategory
{
    using Macsauto.Domain.SalesModule;

    public class ViewPresenter
    {
        private readonly IServiceCategoryRepository _categoryRepository;
        private View _form;

        public ViewPresenter(IServiceCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void SetForm(View form)
        {
            _form = form;
            _form.ServiceCategories = _categoryRepository.GetAll();
        }
    }
}