using System.Linq;

namespace Macsauto.Presentation.WinForm.ManagementModule.Customer
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    
    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private IList<Customer> _customers;
        private Customer _selectedCustomer;

        public View(ViewPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;

                foreach (var customer in _customers)
                {
                    dgvCustomers.Rows.Add(
                        customer.Name.Fullname,
                        customer.Code,
                        customer.CellPhone,
                        customer.IsInActiveMembership
                    );
                }
            }
        }

        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            protected set
            {
                _selectedCustomer = value;

                lblCustomerCode.Text = _selectedCustomer.Code + @" : " + _selectedCustomer.Name.Fullname;
            }
        }

        private void dgvCustomers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var value = dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (value != null)
            {
                SelectedCustomer = _customers.First(x => x.Code == dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }
    }
}