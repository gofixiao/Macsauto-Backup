using System.Collections.Generic;
using Macsauto.Domain.Shared;

namespace Macsauto.Domain.SalesModule
{
    public static class CustomerFactory
    {
        public static Customer CreateCustomer(string code, PersonName name, Address address, IList<Vehicle> vehicles = null)
        {
            var customer = new Customer(code, name, "123");

            if (address != null)
            {
                customer.HomeAddress = address;
            }

            if (vehicles != null)
            {
                foreach (var vehicle in vehicles)
                {
                    customer.AddVehicleRegistration(new VehicleRegistration(customer, vehicle));
                }
            }

            return customer;
        }
    }
}