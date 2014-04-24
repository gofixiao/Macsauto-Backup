﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Macsauto.Domain.Sales.Entities
{
    public class ServiceOrder : Entity, IChargableTransaction
    {
        private VehicleRegistration _vehicleRegistration;
        private string _additionalInformation;
        private IList<ServiceOrderItem> _serviceOrderItems;
        private IList<ServiceOrderProduct> _serviceOrderProduct;
        private Customer _customer;
        private DateTime? _finishedOn;
        private ServiceBooking _serviceBooking;

        public ServiceOrder(Customer customer, VehicleRegistration vehicleRegistration, string additionalInformation = null)
        {
            _customer = customer;
            _vehicleRegistration = vehicleRegistration;
            _additionalInformation = additionalInformation;
            _serviceOrderItems = new List<ServiceOrderItem>();
            _serviceOrderProduct = new List<ServiceOrderProduct>();
        }

        public ServiceOrder(ServiceBooking serviceBooking)
        {
            _customer = serviceBooking.Customer;
            _vehicleRegistration = _serviceBooking.VehicleRegistration;
            _additionalInformation = _serviceBooking.AdditionalInformation;

            foreach (var serviceBookingItem in _serviceBooking.ServiceBookingItems)
            {
                AddServiceOrderItem(serviceBookingItem.Service, serviceBookingItem.Price);
            }

            _serviceBooking = serviceBooking;
        }

        public virtual ServiceBooking ServiceBooking
        {
            get { return _serviceBooking; }
            protected set { _serviceBooking = value; }
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

        public virtual DateTime? FinishedOn
        {
            get { return _finishedOn; }
            protected set { _finishedOn = value; }
        }

        public virtual string AdditionalInformation
        {
            get { return _additionalInformation; }
            protected set { _additionalInformation = value; }
        }

        public virtual IList<ServiceOrderItem> ServiceOrderItems
        {
            get { return _serviceOrderItems; }
            protected set { _serviceOrderItems = value; }
        }

        public virtual IList<ServiceOrderProduct> ServiceOrderProduct
        {
            get { return _serviceOrderProduct; }
            protected set { _serviceOrderProduct = value; }
        }

        public virtual bool IsFinished
        {
            get { return _finishedOn != null; }
        }

        public void AddServiceOrderItem(Service service, long price)
        {
            if(IsFinished) throw new ApplicationException(@"Service order is finished and non-editable");

            _serviceOrderItems.Add(new ServiceOrderItem(this, service, price));
        }

        public void AddServiceOrderProduct(Product product, long quantity, long price)
        {
            if (IsFinished) throw new ApplicationException(@"Service order is finished and non-editable");

            _serviceOrderProduct.Add(new ServiceOrderProduct(this, product, quantity, price));
        }

        public void Finish()
        {
            if (IsFinished) throw new ApplicationException(@"Service order is finished and non-editable");

            _finishedOn = DateTime.Now;
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
            get { return @"SERVICE ORDER"; }
        }

        public double TotalCharge
        {
            get
            {
                double totalCharged = 0;

                totalCharged += _serviceOrderItems.Sum(serviceOrderItem => serviceOrderItem.Price);
                totalCharged += _serviceOrderProduct.Sum(serviceOrderProduct => serviceOrderProduct.Price);

                if (_serviceBooking != null)
                {
                    totalCharged -= _serviceBooking.TotalCharge;
                }

                return totalCharged;
            }
        }

        #endregion
    }
}