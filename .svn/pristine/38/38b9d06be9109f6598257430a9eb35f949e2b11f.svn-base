namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Customer
{
    using System.Linq;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.Connector.SmartCard;
    using Macsauto.Infrastructure.Connector.SmartCard.Reader;

    public class SelectPresenter
    {
        private readonly ICustomerRepository _customerRepository;
        private SmartCardReader _cardReader;
        private Select _form;

        public SelectPresenter(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

            CardManager.Initialize();

            CheckCardReader();
        }

        public void SetForm(Select form)
        {
            _form = form;

            _form.Customers = _customerRepository.GetAll();

            CheckCardReader();
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
    }
}