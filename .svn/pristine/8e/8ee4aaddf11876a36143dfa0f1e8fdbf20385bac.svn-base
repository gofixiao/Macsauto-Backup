namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Payment
{
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;
    using Macsauto.Domain.SalesModule;

    public class CreatePresenter
    {
        private readonly IPaymentService _paymentService;
        private readonly IPaymentRepository _paymentRepository;
        private readonly ICardIssuerRepository _cardIssuerRepository; 
        private Create _form;

        public CreatePresenter(IPaymentService paymentService, IPaymentRepository paymentRepository, ICardIssuerRepository cardIssuerRepository)
        {
            _paymentService = paymentService;
            _paymentRepository = paymentRepository;
            _cardIssuerRepository = cardIssuerRepository;
        }

        public void SetForm(Create form)
        {
            _form = form;

            _form.CardIssuers = _cardIssuerRepository.GetAll();
        }

        public Payment Save()
        {
            Payment payment = null;

            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess =>
                {
                    switch (_form.TenderType)
                    {
                        case TenderType.CASH:
                            payment = _paymentService.PayCash(_form.Transaction, _form.Paid);
                            break;
                        case TenderType.DEBITCARD:
                            payment = _paymentService.PayWithDebitCard(_form.Transaction, _form.DebitCardIssuer, _form.DebitCardNumber);
                            break;
                        case TenderType.CREDITCARD:
                            payment = _paymentService.PayWithCreditCard(_form.Transaction, _form.CreditCardType, _form.CreditCardIssuer, _form.CreditCardNumber);
                            break;
                    }

                    payment = _paymentRepository.Insert(payment);
                });

            return payment;
        }
    }
}