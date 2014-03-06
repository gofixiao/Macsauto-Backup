namespace Macsauto.Presentation.WinForm.ConfigurationModule.UnitOfMeasurement
{
    using Macsauto.Domain.SalesModule;

    public class ViewPresenter
    {
        private readonly IUnitOfMeasurementRepository _measurementRepository;
        private View _form;

        public ViewPresenter(IUnitOfMeasurementRepository measurementRepository)
        {
            _measurementRepository = measurementRepository;
        }

        public void SetForm(View form)
        {
            _form = form;
            _form.UnitOfMeasurements = _measurementRepository.GetAll();
        }
    }
}