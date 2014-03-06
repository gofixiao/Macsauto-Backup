namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Contract;

    public class PaymentService : IPaymentService
    {
        private readonly long _basePoint;

        public PaymentService(long basePoint)
        {
            _basePoint = basePoint;
        }

        public Payment PayCash(ITransaction transaction, long paidAmount)
        {
            var payment = new CashPayment(transaction, transaction.GetTotalCharged(), paidAmount, _basePoint);

            return payment;
        }

        public Payment PayWithDebitCard(ITransaction transaction, CardIssuer cardIssuer, string cardNumber)
        {
            var payment = new DebitCardPayment(transaction, transaction.GetTotalCharged(), cardIssuer, cardNumber, _basePoint);

            return payment;
        }

        public Payment PayWithCreditCard(ITransaction transaction, CreditCardType creditCardType, CardIssuer cardIssuer, string cardNumber)
        {
            var payment = new CreditCardPayment(transaction, transaction.GetTotalCharged(), creditCardType, cardNumber, cardIssuer, _basePoint);

            return payment;
        }
    }
}