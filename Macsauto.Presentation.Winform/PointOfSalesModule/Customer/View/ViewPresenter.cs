namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.Connector.SmartCard;
    using Macsauto.Infrastructure.Connector.SmartCard.Reader;

    public class ViewPresenter
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMembershipRegistrationRepository _membershipRegistrationRepository;
        private readonly MembershipTransactionFetcher _fetcher;
        private SmartCardReader _cardReader;
        private View _form;

        public ViewPresenter(ICustomerRepository customerRepository, IMembershipRegistrationRepository membershipRegistrationRepository, MembershipTransactionFetcher fetcher)
        {
            _customerRepository = customerRepository;
            _membershipRegistrationRepository = membershipRegistrationRepository;
            _fetcher = fetcher;

            CheckCardReader();
        }

        public void SetForm(View form)
        {
            _form = form;

            _form.Customers = _customerRepository.GetAll();
        }

        public DateTime GetFirstActivatedMembership(Customer customer)
        {
            var membershipRegistration = _membershipRegistrationRepository.GetRegistrationOf(customer);

            return membershipRegistration.CreatedOn;
        }

        public IList<MembershipTransactionDto> GetMemberTransactions(Customer customer)
        {
            return _fetcher.Fetch(customer);
        }

        public void GetMember(string membershipCode)
        {
            _form.SelectedCustomer = _customerRepository.GetByMembershipCode(membershipCode);
        }

        private void CheckCardReader()
        {
            _cardReader = CardManager.CardReaders.FirstOrDefault();

            if (_cardReader != null)
            {
                _cardReader.ReaderCardStateChanged += _cardReader_ReaderCardStateChanged;
                _cardReader.StartPolling(400);
            }
        }

        private void _cardReader_ReaderCardStateChanged(object sender, ReaderCardStateChangedEventArgs e)
        {
            if (e.ReaderCardState == ReaderCardState.CARD_PRESENT)
            {
                _form.MembershipId = _cardReader.GetCardBlockValue(1);
            }
        }

        public class MembershipTransactionFetcher
        {
            private readonly IServiceOrderRepository _serviceOrderRepository;
            private readonly IServiceBookingRepository _serviceBookingRepository;
            private readonly IPurchaseOrderRepository _purchaseOrderRepository;
            private readonly IPointRedemptionRepository _pointRedemptionRepository;
            private readonly IPaymentRepository _paymentRepository;
            private IList<MembershipTransactionDto> _membershipTransactions;

            public MembershipTransactionFetcher(IServiceOrderRepository serviceOrderRepository, IServiceBookingRepository serviceBookingRepository, IPurchaseOrderRepository purchaseOrderRepository, IPointRedemptionRepository pointRedemptionRepository, IPaymentRepository paymentRepository)
            {
                _serviceOrderRepository = serviceOrderRepository;
                _serviceBookingRepository = serviceBookingRepository;
                _purchaseOrderRepository = purchaseOrderRepository;
                _pointRedemptionRepository = pointRedemptionRepository;
                _paymentRepository = paymentRepository;

                _membershipTransactions = new List<MembershipTransactionDto>();
            }

            public IList<MembershipTransactionDto> Fetch(Customer customer)
            {
                var serviceOrders = _serviceOrderRepository.GetOrdersOf(customer);
                var serviceBookings = _serviceBookingRepository.GetBookingsOf(customer);
                var purchaseOrders = _purchaseOrderRepository.GetPurchasesOf(customer);
                var pointRedemptions = _pointRedemptionRepository.GetRedemptionsOf(customer);

                foreach (var serviceOrder in serviceOrders)
                {
                    var payment = _paymentRepository.GetPaymentForTransaction(serviceOrder);

                    if (payment != null)
                    {
                        _membershipTransactions.Add(
                            new MembershipTransactionDto(
                                serviceOrder.Id.ToString(),
                                @"SERVICEORDER",
                                serviceOrder.Code,
                                serviceOrder.CreatedOn,
                                payment.Charged,
                                0
                            )
                        );
                    }
                }

                return _membershipTransactions;
            }
        }
    }
}