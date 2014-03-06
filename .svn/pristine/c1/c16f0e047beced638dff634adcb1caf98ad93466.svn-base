namespace Macsauto.Presentation.WinForm.PointOfSalesModule.ServiceBooking
{
    using System;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class CreatePresenter
    {
        private readonly IServiceBookingRepository _serviceBookingRepository;
        private readonly IServiceCategoryRepository _serviceCategoryRepository;
        private readonly IServiceRepository _serviceRepository;
        private Create _form;
        
        public CreatePresenter(IServiceBookingRepository serviceBookingRepository, IServiceRepository serviceRepository, IServiceCategoryRepository serviceCategoryRepository)
        {
            _serviceBookingRepository = serviceBookingRepository;
            _serviceRepository = serviceRepository;
            _serviceCategoryRepository = serviceCategoryRepository;
        }

        public void SetForm(Create form)
        {
            _form = form;

            _form.ServiceCategories = _serviceCategoryRepository.GetAll();
            _form.Services = _serviceRepository.GetAll();
        }

        public ServiceBooking Save()
        {
            ServiceBooking serviceBooking = null;

            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    serviceBooking = new ServiceBooking(
                        _form.Customer,
                        _form.VehicleRegistration,
                        DateTime.Now.AddDays(10)
                    );

                    foreach (var serviceBookingDto in _form.ServiceBookingDtos)
                    {
                        serviceBooking.AddBookingItem(serviceBookingDto.Service, serviceBookingDto.Price);
                    }

                    serviceBooking = _serviceBookingRepository.Insert(serviceBooking);
                });

            return serviceBooking;
        }
    }
}