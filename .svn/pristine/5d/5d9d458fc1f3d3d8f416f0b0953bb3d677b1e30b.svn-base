namespace Macsauto.Presentation.WinForm.ManagementModule.Customer
{
    using System;
    using System.Windows.Forms;
    using System.Linq;
    using Macsauto.Infrastructure.Connector.SmartCard;
    using Macsauto.Infrastructure.Connector.SmartCard.Reader;
    using Macsauto.Infrastructure.Service;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Domain.Shared;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class AddPresenter
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IVehicleBrandRepository _brandRepo;
        private readonly IVehicleModelRepository _modelRepo;
        private readonly IVehicleRegistrationRepository _registrationRepo;
        private readonly IProvinceRepository _provinceRepo;
        private readonly ICityRepository _cityRepo;
        private readonly IMembershipRegistrationRepository _membershipRegistrationRepo;
        private Add _view;
        private SmartCardReader _cardReader;

        public AddPresenter(ICustomerRepository customerRepo, 
                            IVehicleBrandRepository brandRepo,
                            IVehicleModelRepository modelRepo, 
                            IProvinceRepository provinceRepo,
                            ICityRepository cityRepo, 
                            IVehicleRegistrationRepository registrationRepo, 
                            IMembershipRegistrationRepository membershipRegistrationRepo)
        {
            CardManager.Initialize();

            CheckCardReader();

            _customerRepo = customerRepo;
            _brandRepo = brandRepo;
            _modelRepo = modelRepo;
            _provinceRepo = provinceRepo;
            _cityRepo = cityRepo;
            _registrationRepo = registrationRepo;
            _membershipRegistrationRepo = membershipRegistrationRepo;
        }

        public void SetForm(Add view)
        {
            _view = view;
            _view.CustomerCode = string.Format("C{0}{1:00}", 
                                                LoginService.LoggedInUserBranch.Code.Substring(1),
                                               _customerRepo.Count() + 1);
            _view.VehicleBrands = _brandRepo.GetAll();
            _view.Provinces = _provinceRepo.GetAll();
        }

        public void GetModel(VehicleBrand brand)
        {
            _view.VehicleModels = _modelRepo.GetAllInBrand(brand);
        }

        public void GetCity(Province selectedProvince)
        {
            _view.Cities = _cityRepo.GetWhereProvince(selectedProvince);
        }

        public Customer Save()
        {
            if (_cardReader == null)
            {
                if (MessageBox.Show(@"Card reader is not ready, retry?", @"Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CheckCardReader();
                }
                else
                {
                    throw new ApplicationException(@"Cannot save membership data. Card reader is not ready");
                }
            }

            Customer customer = CustomerFactory.CreateCustomer(
                _view.CustomerCode,
                new PersonName(_view.Firstname, _view.Middlename, _view.Lastname),
                new Address(_view.City, _view.Zipcode, _view.AddressLine),
                _view.Vehicles
            );

            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    customer = _customerRepo.Insert(customer);

                    if (_view.WantsToBeAMember)
                    {
                        var membershipRegistration = customer.RegisterAsMember();

                        _membershipRegistrationRepo.Insert(membershipRegistration);
                    }

                    customer = _customerRepo.Insert(customer);
                });

            return customer;
        }

        private void CheckCardReader()
        {
            _cardReader = CardManager.CardReaders.FirstOrDefault();

            if (_cardReader != null)
            {
                _cardReader.StartPolling(400);
            }
        }
    }
}