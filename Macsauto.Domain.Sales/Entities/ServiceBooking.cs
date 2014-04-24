using System;
using System.Collections.Generic;
using System.Linq;

namespace Macsauto.Domain.Sales.Entities
{
    public class ServiceBooking : Entity, IChargableTransaction
    {
        private Customer _customer;
        private VehicleRegistration _vehicleRegistration;
        private string _additionalInformation;
        private DateTime _dueDate;
        private IList<ServiceBookingItem> _serviceBookingItems;
        private DateTime? _checkedOutOn;

        public ServiceBooking(Customer customer, VehicleRegistration vehicleRegistration, DateTime dueDate)
        {
            _customer = customer;
            _vehicleRegistration = vehicleRegistration;
            _dueDate = dueDate;
            _serviceBookingItems = new List<ServiceBookingItem>();
        }

        public ServiceBooking(Customer customer, VehicleRegistration vehicleRegistration, DateTime dueDate, string additionalInformation)
        {
            _customer = customer;
            _vehicleRegistration = vehicleRegistration;
            _dueDate = dueDate;
            _additionalInformation = additionalInformation;
            _serviceBookingItems = new List<ServiceBookingItem>();
        }

        public virtual Customer Customer
        {
            get { return _customer; }
            protected set { _customer = value; }
        }

        public virtual VehicleRegistration VehicleRegistration
        {
            get { return _vehicleRegistration; }
            protected set { _vehicleRegistration = value; }
        }

        public virtual string AdditionalInformation
        {
            get { return _additionalInformation; }
            protected set { _additionalInformation = value; }
        }

        public virtual DateTime DueDate
        {
            get { return _dueDate; }
            protected set { _dueDate = value; }
        }

        public virtual DateTime? CheckedOutOn
        {
            get { return _checkedOutOn; }
            protected set { _checkedOutOn = value; }
        }

        public virtual IList<ServiceBookingItem> ServiceBookingItems
        {
            get { return _serviceBookingItems; }
            protected set { _serviceBookingItems = value; }
        }

        public virtual void AddBookingItem(Service service, long price)
        {
            _serviceBookingItems.Add(new ServiceBookingItem(this, service, price));
        }

        public virtual ServiceOrder CheckOut()
        {
            _checkedOutOn = DateTime.Now;

            var serviceOrder = new ServiceOrder(this);

            return serviceOrder;
        }

        #region IChargableTransaction Members

        public Customer TransactionCustomer
        {
            get { return _customer; }
        }

        public string TransactionCode
        {
            get { return Code; }
        }

        public string TransactionName
        {
            get { return @"SERVICE BOOKING"; }
        }

        public double TotalCharge
        {
            get { return _serviceBookingItems.Sum(serviceBookingItem => serviceBookingItem.Price); }
        }

        #endregion
    }
}