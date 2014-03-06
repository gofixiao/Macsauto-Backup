namespace Macsauto.Presentation.WinForm.ConfigurationModule.UnitOfMeasurement
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class AddPresenter
    {
        private readonly IUnitOfMeasurementRepository _measurementRepository;
        private Add _form;

        public AddPresenter(IUnitOfMeasurementRepository measurementRepository)
        {
            _measurementRepository = measurementRepository;
        }

        public void SetForm(Add form)
        {
            _form = form;
        }

        public UnitOfMeasurement Save()
        {
            UnitOfMeasurement uom = null;
            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    uom = _measurementRepository.Insert(
                        new UnitOfMeasurement(_form.MeasurementName, _form.MeasurementDescription)
                        );
                });

            return uom;
        }
    }
}