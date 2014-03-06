namespace Macsauto.Domain.SalesModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Macsauto.Domain.Shared;

    public class Service : Entity
    {
        private IList<ServicePricing> _servicePrices;
        private ServiceCategory _category;
        private string _name;
        private string _description;

        protected Service() {}

        public Service(string code, ServiceCategory category, string name)
        {
            _code = code;
            _category = category;
            _name = name;
            _servicePrices = new List<ServicePricing>();
        }

        public Service(string code, ServiceCategory category, string name, string description)
        {
            _code = code;
            _category = category;
            _name = name;
            _description = description;
            _servicePrices = new List<ServicePricing>();
        }

        public virtual ServiceCategory Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public virtual IList<ServicePricing> ServicePrices
        {
            get { return _servicePrices; }
            protected set { _servicePrices = value; }
        }

        public virtual void AddPrice(VehicleSize vehicleSize, long price)
        {
            _servicePrices.Add(new ServicePricing(this, vehicleSize, price));
        }

        public virtual void UpdatePrice(VehicleSize vehicleSize, long price)
        {
            var servicePrice = _servicePrices.First(sp => sp.VehicleSize == vehicleSize);

            _servicePrices.Remove(servicePrice);
            _servicePrices.Add(new ServicePricing(this, vehicleSize, price));
        }

        public virtual long GetPriceForVehicle(Vehicle vehicle)
        {
            var vehicleSize = vehicle.Model.Size;
            var servicePrice = _servicePrices.FirstOrDefault(sp => sp.VehicleSize == vehicleSize);

            if (servicePrice == null)
            {
                throw new ApplicationException(string.Format(@"No price found in service '{0}' for vehicle size '{1}'", Name, vehicleSize));
            }

            return servicePrice.Price;
        }
    }
}