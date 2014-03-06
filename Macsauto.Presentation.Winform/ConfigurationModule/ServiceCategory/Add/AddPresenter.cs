namespace Macsauto.Presentation.WinForm.ConfigurationModule.ServiceCategory
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class AddPresenter
    {
        private readonly IServiceCategoryRepository _categoryRepository;
        private Add _form;

        public AddPresenter(IServiceCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void SetForm(Add form)
        {
            _form = form;
        }

        public ServiceCategory Save()
        {
            ServiceCategory serviceCategory = null;
            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    serviceCategory = new ServiceCategory(
                        _form.Code,
                        _form.CategoryName,
                        _form.CategoryDescription
                    );

                    serviceCategory = _categoryRepository.Insert(serviceCategory);
                });

            return serviceCategory; 
        }
    }
}