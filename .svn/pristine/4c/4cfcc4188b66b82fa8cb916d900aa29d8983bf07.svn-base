namespace Macsauto.Presentation.WinForm.PointOfSalesModule.ServiceBooking
{
    using Macsauto.Domain.SalesModule;

    public class ViewPresenter
    {
        private readonly IServiceBookingRepository _serviceBookingRepository;
        private View _form;

        public ViewPresenter(IServiceBookingRepository serviceBookingRepository)
        {
            _serviceBookingRepository = serviceBookingRepository;
        }

        public void SetForm(View form)
        {
            _form = form;

            _form.PendingBookings = _serviceBookingRepository.GetAllPendingBookings();
        }
    }
}