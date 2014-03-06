namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Dashboard
{
    using Macsauto.Domain.SalesModule;

    public class DashboardPresenter
    {
        private readonly IServiceOrderRepository _serviceOrderRepository;
        private Dashboard _form;

        public DashboardPresenter(IServiceOrderRepository serviceOrderRepository)
        {
            _serviceOrderRepository = serviceOrderRepository;
        }

        public void SetForm(Dashboard form)
        {
            _form = form;

            _form.PendingServiceOrders = _serviceOrderRepository.GetAllPendingOrders();
        }
    }
}