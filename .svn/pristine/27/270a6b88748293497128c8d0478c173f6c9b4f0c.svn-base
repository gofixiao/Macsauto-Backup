namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Payment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.Contract;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Presentation.WinForm.PointOfSalesModule.Common;

    public partial class Create : BaseForm
    {
        private readonly CreatePresenter _presenter;
        private IList<CardIssuer> _cardIssuers;
        private long _charged;

        public event EventHandler FinalizingPayment;

        protected virtual void OnFinalizingPayment()
        {
            var handler = FinalizingPayment;

            if (handler != null) handler(this, EventArgs.Empty);
        }

        public Create(CreatePresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            cboPaymentMethod.SelectedIndex = 0;
            radVisa.Checked = true;
        }

        public IList<CardIssuer> CardIssuers
        {
            get { return _cardIssuers; }
            set
            {
                _cardIssuers = value;

                cboDebitCardIssuer.Items.Clear();
                cboCreditCardIssuer.Items.Clear();

                foreach (var cardIssuer in _cardIssuers)
                {
                    cboDebitCardIssuer.Items.Add(cardIssuer.Name);
                    cboCreditCardIssuer.Items.Add(cardIssuer.Name);
                }
            }
        }

        public ITransaction Transaction { get; set; }

        public long Charged
        {
            get { return _charged; }
            set
            {
                _charged = value;

                txtCharged.Text = _charged.ToString(@"N");
            }
        }

        public long Paid
        {
            get { return long.Parse(txtPaid.Text); }
        }

        public TenderType TenderType
        {
            get
            {
                switch (cboPaymentMethod.SelectedIndex)
                {
                    case 0:
                        return TenderType.CASH;
                    case 1:
                        return TenderType.DEBITCARD;
                    case 2:
                        return TenderType.CREDITCARD;
                }

                return TenderType.CASH;
            }
        }

        public CardIssuer DebitCardIssuer
        {
            get { return _cardIssuers.First(x => x.Name == cboDebitCardIssuer.SelectedItem.ToString()); }
        }

        public string DebitCardNumber
        {
            get { return txtDebitCardNumber.Text; }
        }

        public CreditCardType CreditCardType
        {
            get { return radVisa.Checked ? CreditCardType.VISA : CreditCardType.MASTERCARD; }
        }

        public CardIssuer CreditCardIssuer
        {
            get { return _cardIssuers.First(x => x.Name == cboCreditCardIssuer.SelectedItem.ToString()); }
        }

        public string CreditCardNumber
        {
            get { return txtCreditCardNumber.Text; }
        }

        private void Create_Load(object sender, EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;

            _presenter.SetForm(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                OnFinalizingPayment();

                var payment = _presenter.Save();

                //OnFormTransactionSuccess(new FormTransactionSuccessArgs<Payment>(payment, true));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlPaymentMethodCash.Visible = cboPaymentMethod.SelectedIndex == 0;
            pnlPaymentMethodDebitCard.Visible = cboPaymentMethod.SelectedIndex == 1;
            pnlPaymentMethodCreditCard.Visible = cboPaymentMethod.SelectedIndex == 2;
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            long paid;
            long charged;

            long.TryParse(txtPaid.Text, out paid);
            long.TryParse(txtCharged.Text, out charged);

            txtChange.Text = (paid - charged) <= 0 ? @"0" : (paid - charged).ToString(@"N");
        }
    }
}