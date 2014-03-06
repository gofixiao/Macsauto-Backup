namespace Macsauto.Presentation.WinForm.ManagementModule.Service
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class AddPresenter
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IServiceCategoryRepository _categoryRepository;
        private Add _form;

        public AddPresenter(IServiceRepository serviceRepository, IServiceCategoryRepository categoryRepository)
        {
            _serviceRepository = serviceRepository;
            _categoryRepository = categoryRepository;
        }

        public void SetForm(Add form)
        {
            _form = form;

            _form.ServiceCategories = _categoryRepository.GetAll();
        }

        public Service Save()
        {
            Service service = null;

            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    service = new Service(
                        _form.ServiceCode,
                        _form.ServiceCategory,
                        _form.ServiceName,
                        _form.ServiceDescription
                    );

                    foreach (var servicePricing in _form.ServicePricings)
                    {
                        service.AddPrice(
                            servicePricing.VehicleSize,
                            servicePricing.Price
                        );
                    }

                    service = _serviceRepository.Insert(service);
                });

            return service;
        }
    }
}