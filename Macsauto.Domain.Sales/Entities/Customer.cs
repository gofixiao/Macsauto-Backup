﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Macsauto.Domain.Sales.Customer
{
    using Macsauto.Domain.Sales.Customer.Membership;
    using Macsauto.Domain.Sales.Vehicle;

    public class Customer : Person
    {
        private string _cellPhone;
        private Membership.Membership _membership;
        private IList<VehicleRegistration> _vehicleRegistrations;

        public Customer(PersonName name, string cellPhone) : base(name)
        {
            _cellPhone = cellPhone;
            _vehicleRegistrations = new List<VehicleRegistration>();
        }

        public virtual string HomePhone { get; set; }

        public virtual string CellPhone
        {
            get { return _cellPhone; }
            set { _cellPhone = value; }
        }

        public virtual string Email { get; set; }

        public virtual Address HomeAddress { get; set; }

        public virtual Membership.Membership Membership
        {
            get { return _membership; }
            protected set { _membership = value; }
        }

        public virtual string MembershipStatus
        {
            get
            {
                if (_membership == null)
                {
                    return @"NON-MEMBER";
                }

                return IsInActiveMembership ? @"MEMBER" : @"MEMBERSHIP EXPIRED";
            }
        }

        public virtual IList<VehicleRegistration> VehicleRegistrations
        {
            get { return _vehicleRegistrations; }
            protected set { _vehicleRegistrations = value; }
        }

        public virtual bool IsInActiveMembership
        {
            get { return _membership != null && _membership.IsActive; }
        }

        public virtual MembershipRegistration RegisterAsMember()
        {
            if (IsInActiveMembership)
            {
                throw new ApplicationException(@"Customer already is a member");
            }

            var registration = new MembershipRegistration(this);

            _membership = new Membership.Membership();

            return registration;
        }

        public virtual PointRedemption.PointRedemption RedeemPoint(IList<Merchandise.Merchandise> merchandises, string remark = @"")
        {
            if (!IsInActiveMembership)
            {
                throw new ApplicationException(@"Customer is not in active membership");
            }

            var totalPointNeeded = merchandises.Sum(x => x.PointCost);

            if (totalPointNeeded > _membership.Point)
            {
                throw new ApplicationException(@"Not enough points, " + totalPointNeeded + @" needed");
            }

            var pointRedemption = new PointRedemption.PointRedemption(this, remark);

            foreach (var merchandise in merchandises)
            {
                pointRedemption.AddRedemptionItem(merchandise, 1);

                _membership.UsePoint(merchandise.PointCost);
            }

            return pointRedemption;
        }

        public virtual void AddVehicleRegistration(VehicleRegistration vehicleRegistration)
        {
            _vehicleRegistrations.Add(vehicleRegistration);
        }

        public override string ToString()
        {
            return Name.Fullname;
        }

        public override string GenerateNewCode<T>(IRepository<T> repository)
        {
            return string.Format(@"CU{0:00}{1:000}", 
                repository.GetLastMonthlyIndex() + 1,
                repository.GetLastDailyIndex() + 1);
        }
    }
}