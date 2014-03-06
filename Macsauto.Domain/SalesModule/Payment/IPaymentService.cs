namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Contract;

    public interface IPaymentService
    {
        Payment PayCash(ITransaction transaction, long paidAmount);
        Payment PayWithDebitCard(ITransaction transaction, CardIssuer cardIssuer, string cardNumber);
        Payment PayWithCreditCard(ITransaction transaction, CreditCardType creditCardType, CardIssuer cardIssuer, string cardNumber);
    }
}