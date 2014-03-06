using Macsauto.Domain.SalesModule;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Vehicle.Brand
{
    public class ViewPresenter
    {
        private readonly IVehicleBrandRepository _brandRepo;
        private readonly IVehicleModelRepository _modelRepo;
        private View _form;

        public ViewPresenter(IVehicleBrandRepository brandRepo, IVehicleModelRepository modelRepo)
        {
            _brandRepo = brandRepo;
            _modelRepo = modelRepo;
        }

        public void SetForm(View form)
        {
            _form = form;

            _form.Brands = _brandRepo.GetAll();
        }

        public void GetModel(VehicleBrand selectedBrand)
        {
            _form.Models = _modelRepo.GetAllInBrand(selectedBrand);
        }
    }
}