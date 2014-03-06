namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Presentation.WinForm.CustomArgs;

    public partial class Select : Form
    {
        private readonly SelectPresenter _presenter;
        private IList<Customer> _customers;
        private string _membershipId;

        public event EventHandler<FormSelectionArgs<Customer>> FormSelection;

        protected virtual void OnFormSelection(FormSelectionArgs<Customer> e)
        {
            var handler = FormSelection;

            if (handler != null) handler(this, e);
        }

        public Select(SelectPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public string MembershipId { set { txtSearch.Text = value;} }
    }
}
