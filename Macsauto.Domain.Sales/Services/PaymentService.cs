using System;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Services
{
    public class PaymentService
    {
        public Payment MakePayment(Customer customer, IChargable chargable)
        {
            
        }

        public int CalculatePointsEarned(IChargable chargable, double basePoint)
        {
            return (int) Math.Floor(chargable.GetTotalCharged() / basePoint);
        }
    }
}