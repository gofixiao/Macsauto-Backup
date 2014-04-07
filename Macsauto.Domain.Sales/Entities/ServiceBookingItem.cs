namespace Macsauto.Domain.Sales.Entities
{
    public class ServiceBookingItem : ValueObject<ServiceBookingItem>
    {
        private ServiceBooking _serviceBooking;
        private Service _service;
        private long _price;
        private long _currentPrice;

        protected ServiceBookingItem()
        {
        }

        public ServiceBookingItem(ServiceBooking serviceBooking, Service service, long price)
        {
            _serviceBooking = serviceBooking;
            _service = service;
            _price = price;
            _currentPrice = service.GetPriceForVehicle(serviceBooking.VehicleRegistration.RegisteredVehicle);            
        }

        public virtual ServiceBooking ServiceBooking
        {
            get { return _serviceBooking; }
            protected set { _serviceBooking = value; }
        }

        public virtual Service Service
        {
            get { return _service; }
            protected set { _service = value; }
        }

        public virtual long Price
        {
            get { return _price; }
            protected set { _price = value; }
        }

        public virtual long CurrentPrice
        {
            get { return _currentPrice; }
            protected set { _currentPrice = value; }
        }

        public virtual long Discount
        {
            get { return _currentPrice - _price; }
        }
    }
}