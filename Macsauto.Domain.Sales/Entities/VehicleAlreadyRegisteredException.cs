using System;

namespace Macsauto.Domain.Sales.Entities
{
    [Serializable]
    public class VehicleAlreadyRegisteredException : ApplicationException
    {
        private readonly Customer _customer;
        private readonly Vehicle _vehicle;

        public VehicleAlreadyRegisteredException(Customer customer, Vehicle vehicle)
        {
            _customer = customer;
            _vehicle = vehicle;
        }

        public override string Message
        {
            get
            {
                return string.Format("Vehicle {0} is already registered to Customer {1}", 
                    _vehicle.RegistrationNumber,
                    _customer.Name.Fullname);
            }
        }
    }
}
