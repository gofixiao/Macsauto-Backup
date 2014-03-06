using Macsauto.Domain.SalesModule;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Vehicle.Model
{
    public class ViewPresenter
    {
        private readonly IVehicleModelRepository _modelRepo;
        private View _form;

        public ViewPresenter(IVehicleModelRepository modelRepo)
        {
            _modelRepo = modelRepo;
        }

        public void SetForm(View form)
        {
            _form = form;

            _form.VehicleModels = _modelRepo.GetAll();
        }
    }
}