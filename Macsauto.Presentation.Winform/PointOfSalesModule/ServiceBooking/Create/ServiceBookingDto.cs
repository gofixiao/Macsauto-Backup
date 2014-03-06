namespace Macsauto.Presentation.WinForm.PointOfSalesModule.ServiceBooking
{
    using Macsauto.Domain.SalesModule;

    public class ServiceBookingDto
    {
        private readonly Service _service;
        private readonly long _price;

        public ServiceBookingDto(Service service, long price)
        {
            _service = service;
            _price = price;
        }

        public Service Service
        {
            get { return _service; }
        }

        public long Price
        {
            get { return _price; }
        }
    }
}