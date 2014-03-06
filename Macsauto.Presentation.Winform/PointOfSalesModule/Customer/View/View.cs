namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Presentation.WinForm.CustomArgs;

    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private IList<Customer> _customers;
        private Customer _selectedCustomer;

        public event EventHandler<FormSelectionArgs<VehicleRegistration>> VehicleSelection;
        public event EventHandler<FormSelectionArgs<Customer>> CustomerSelection;

        protected virtual void OnCustomerSelection(FormSelectionArgs<Customer> e)
        {
            var handler = CustomerSelection;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnVehicleSelection(FormSelectionArgs<VehicleRegistration> e)
        {
            var handler = VehicleSelection;
            if (handler != null) handler(this, e);
        }

        public View(ViewPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);

            cboMemberStatus.SelectedIndex = 0;
        }

        public IList<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;

                dgvCustomers.Rows.Clear();

                foreach (var customer in _customers)
                {
                    dgvCustomers.Rows.Add(
                        customer.Id,
                        customer.Name.Fullname,
                        customer.CellPhone,
                        customer.MembershipStatus
                    );
                }
            }
        }

        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;

                var membership = _selectedCustomer.Membership;

                lblCustomerCode.Text = _selectedCustomer.Code;
                txtFullname.Text = _selectedCustomer.Name.Fullname;
                txtCellphone.Text = _selectedCustomer.CellPhone;
                txtAddress.Text = _selectedCustomer.HomeAddress.ToString();
                txtPhone.Text = _selectedCustomer.HomePhone;
                txtEmail.Text = _selectedCustomer.Email;

                lblMemberStatus.Text = _selectedCustomer.MembershipStatus;

                if (membership != null)
                {
                    gbxMembershipData.Visible = true;

                    dtpMemberSince.Value = _presenter.GetFirstActivatedMembership(_selectedCustomer);

                    var transactions = _presenter.GetMemberTransactions(_selectedCustomer);

                    
                }

                dgvVehicles.Rows.Clear();

                foreach (var vehicleRegistration in _selectedCustomer.VehicleRegistrations)
                {
                    dgvVehicles.Rows.Add(
                        vehicleRegistration.RegisteredVehicle.RegistrationNumber,
                        vehicleRegistration.RegisteredVehicle.Model.Brand.ToString(),
                        vehicleRegistration.RegisteredVehicle.Model.ToString(),
                        vehicleRegistration.RegisteredVehicle.Model.Type,
                        vehicleRegistration.RegisteredVehicle.Color,
                        vehicleRegistration.RegisteredVehicle.CurrentKM
                    );
                }

                txtTotalCar.Text = dgvVehicles.Rows.Cast<DataGridViewRow>().Count(row => row.Cells[3].Value.ToString() == VehicleType.CAR.ToString()).ToString(CultureInfo.InvariantCulture);
                txtTotalMotor.Text = dgvVehicles.Rows.Cast<DataGridViewRow>().Count(row => row.Cells[3].Value.ToString() == VehicleType.MOTORCYCLE.ToString()).ToString(CultureInfo.InvariantCulture);
            }
        }

        public string MembershipId
        {
            set { txtSearch.Text = value; }
        }

        private void View_Load(object sender, EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            txtSearch.Focus();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void dgvCustomers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.Rows.Count > 0)
            {
                SelectedCustomer = _customers.First(x => x.Id.ToString() == dgvCustomers[0, e.RowIndex].Value.ToString());
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer != null)
            {
                RaiseEvent();
            }
            else
            {
                MessageBox.Show(@"No customer selected. Exiting.");
            }

            Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 16)
            {
                _presenter.GetMember(txtSearch.Text);

                if (_selectedCustomer != null)
                {
                    RaiseEvent();
                }
            }
        }

        public void RaiseEvent()
        {
            VehicleRegistration selectedVehicle = null;

            selectedVehicle = dgvVehicles.SelectedCells.Count > 0 ? _selectedCustomer.VehicleRegistrations.First(x => x.RegisteredVehicle.RegistrationNumber == dgvVehicles[0, dgvVehicles.SelectedCells[0].RowIndex].Value.ToString()) : _selectedCustomer.VehicleRegistrations.First(x => x.RegisteredVehicle.RegistrationNumber == dgvVehicles[0, 0].Value.ToString());

            OnCustomerSelection(new FormSelectionArgs<Customer>(selectedVehicle.RegisteredTo));
            OnVehicleSelection(new FormSelectionArgs<VehicleRegistration>(selectedVehicle));
        }
    }
}