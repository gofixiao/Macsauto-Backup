using System;
using Macsauto.Domain.Shared;
using Macsauto.Domain.UserManagementModule;

namespace Macsauto.Domain.SalesModule
{
    public class ServiceOrderItem : ValueObject<ServiceOrderItem>
    {
        private ServiceOrder _serviceOrder;
        private Service _service;
        private long _currentPrice;
        private long _price;
        private string _voidReason;
        private DateTime _voidOn;
        private Employee _voidBy;

        protected ServiceOrderItem()
        {
        }

        public ServiceOrderItem(ServiceOrder serviceOrder, Service service, long price)
        {
            _serviceOrder = serviceOrder;
            _service = service;
            _price = price;
            _currentPrice = service.GetPriceForVehicle(serviceOrder.VehicleRegistration.RegisteredVehicle);
        }

        public virtual ServiceOrder ServiceOrder
        {
            get { return _serviceOrder; }
            protected set { _serviceOrder = value; }
        }

        public virtual Service Service
        {
            get { return _service; }
            protected set { _service = value; }
        }

        public virtual long CurrentPrice
        {
            get { return _currentPrice; }
            protected set { _currentPrice = value; }
        }

        public virtual long Price
        {
            get { return _price; }
            protected set { _price = value; }
        }

        public virtual long Discount
        {
            get { return _currentPrice - _price; }
        }

        public virtual Employee VoidBy
        {
            get { return _voidBy; }
            protected set { _voidBy = value; }
        }

        public virtual string VoidReason
        {
            get { return _voidReason; }
            protected set { _voidReason = value; }
        }

        public virtual DateTime VoidOn
        {
            get { return _voidOn; }
            protected set { _voidOn = value; }
        }

        public virtual void Void(Employee manager, string reason)
        {
            if (manager.Position != Position.STOREMANAGER)
            {
                throw new ApplicationException("Store Manager authorization required");
            }

            _voidBy = manager;
            _voidReason = reason;
            _voidOn = DateTime.Now;
        }
    }
}