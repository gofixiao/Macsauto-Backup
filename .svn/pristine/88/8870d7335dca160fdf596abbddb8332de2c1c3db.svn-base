using Macsauto.Domain.SalesModule;
using Macsauto.Infrastructure.NHibernate;
using Macsauto.Infrastructure.NHibernate.Common;
using NHibernate;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Vehicle.Brand
{
    public class AddPresenter
    {
        private readonly IVehicleBrandRepository _brandRepo;
        private Add _form;

        public AddPresenter(IVehicleBrandRepository brandRepo)
        {
            _brandRepo = brandRepo;
        }

        public void SetForm(Add form)
        {
            _form = form;
        }

        public VehicleBrand Save(string code, string name)
        {
            VehicleBrand brand = null;
            ISession session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    brand = _brandRepo.Insert(
                        new VehicleBrand(code, name));
                });

            return brand;
        }
    }
}