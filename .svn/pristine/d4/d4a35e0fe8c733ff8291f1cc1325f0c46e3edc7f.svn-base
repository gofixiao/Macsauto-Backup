using Macsauto.Domain.SalesModule;
using Macsauto.Infrastructure.NHibernate;
using Macsauto.Infrastructure.NHibernate.Common;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Vehicle.Model
{
    public class AddPresenter
    {
        private readonly IVehicleModelRepository _modelRepo;
        private readonly IVehicleBrandRepository _brandRepo;
        private Add _form;

        public AddPresenter(IVehicleModelRepository modelRepo, IVehicleBrandRepository brandRepo)
        {
            _modelRepo = modelRepo;
            _brandRepo = brandRepo;
        }

        public void SetForm(Add form)
        {
            _form = form;

            _form.VehicleBrands = _brandRepo.GetAll();
        }

        public VehicleModel Save(string code, string name, VehicleBrand brand, VehicleSize size, VehicleType type)
        {
            VehicleModel newModel = null;
            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    newModel = _modelRepo.Insert(new VehicleModel(code, name, brand, size, type));
                });

            return newModel;
        }
    }
}