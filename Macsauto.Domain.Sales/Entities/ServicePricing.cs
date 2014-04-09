namespace Macsauto.Domain.Sales.Entities
{
    public class ServicePricing : ValueObject<ServicePricing>
    {
        private Service _service;
        private VehicleSize _vehicleSize;
        private long _price;

        protected ServicePricing(){}

        public ServicePricing(Service service, VehicleSize vehicleSize, long price)
        {
            _service = service;
            _vehicleSize = vehicleSize;
            _price = price;
        }

        public virtual Service Service  
        {
            get { return _service; }
            protected set { _service = value; }
        }

        public virtual VehicleSize VehicleSize
        {
            get { return _vehicleSize; }
            protected set { _vehicleSize = value; }
        }

        public virtual long Price
        {
            get { return _price; }
            protected set { _price = value; }
        }
    }
}
