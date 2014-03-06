using System;
using Macsauto.Domain.Shared;

namespace Macsauto.Domain.SalesModule
{
    public class VehicleRegistration : Entity
    {
        private Customer _registeredTo;
        private Vehicle _registeredVehicle;
        private DateTime _expiryDate;

        protected VehicleRegistration()
        {
        }

        public VehicleRegistration(Customer customer, Vehicle vehicle)
        {
            _registeredTo = customer;
            _registeredVehicle = vehicle;
        }

        public VehicleRegistration(Customer customer, Vehicle vehicle, DateTime expiryDate)
        {
            _registeredTo = customer;
            _registeredVehicle = vehicle;
            _expiryDate = expiryDate;
        }

        public virtual Customer RegisteredTo
        {
            get { return _registeredTo; }
            protected set { _registeredTo = value; }
        }

        public virtual Vehicle RegisteredVehicle
        {
            get { return _registeredVehicle; }
            protected set { _registeredVehicle = value; }
        }

        public virtual DateTime ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }
    }
}