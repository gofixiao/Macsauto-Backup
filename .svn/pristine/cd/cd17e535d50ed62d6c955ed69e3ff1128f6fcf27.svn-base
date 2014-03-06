namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Dashboard
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;

    public partial class Dashboard : Form
    {
        private readonly DashboardPresenter _presenter;
        private readonly IFormFactory _formFactory;
        private IList<ServiceOrder> _pendingServiceOrders;
        private ServiceOrder _selectedServiceOrder;

        public Dashboard(DashboardPresenter presenter, IFormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<ServiceOrder> PendingServiceOrders
        {
            get { return _pendingServiceOrders; }
            set
            {
                _pendingServiceOrders = value;

                dgvPendingServices.Rows.Clear();

                foreach (var serviceOrder in _pendingServiceOrders)
                {
                    dgvPendingServices.Rows.Add(
                        serviceOrder.Id,
                        serviceOrder.Code,
                        serviceOrder.Customer.Name.Fullname,
                        serviceOrder.Customer.CellPhone,
                        serviceOrder.CreatedOn.ToString(@"d")
                    );
                }
            }
        }

        public ServiceOrder SelectedServiceOrder
        {
            get { return _selectedServiceOrder; }
            set
            {
                _selectedServiceOrder = value;

                var serviceCustomer = _selectedServiceOrder.Customer;
                var serviceVehicle = _selectedServiceOrder.VehicleRegistration.RegisteredVehicle;
                var memberStatus = serviceCustomer.IsInActiveMembership ? @"MEMBER" : @"NON-MEMBER";

                lblServiceCode.Text = _selectedServiceOrder.Code + @" - " + serviceCustomer.Name.Fullname;
                lblCustomerCode.Text = serviceCustomer.Code + @" - " + memberStatus;
                lblVehicle.Text = serviceVehicle.RegistrationNumber;
                lblVehicleBrand.Text = serviceVehicle.Model.Brand.Name;
                lblVehicleModel.Text = serviceVehicle.Model.Name;
                lblVehicleColor.Text = serviceVehicle.Color;
                lblCurrentKm.Text = serviceVehicle.CurrentKM.ToString(CultureInfo.InvariantCulture);

                dgvServiceItem.Rows.Clear();
                dgvServiceProduct.Rows.Clear();

                foreach (var serviceOrderItem in _selectedServiceOrder.ServiceOrderItems)
                {
                    dgvServiceItem.Rows.Add(
                        serviceOrderItem.Service.Name,
                        serviceOrderItem.Price,
                        serviceOrderItem.Discount,
                        new DataGridViewButtonCell
                        {
                            Value = @"Void"
                        }
                    );
                }

                foreach (var serviceOrderProduct in _selectedServiceOrder.ServiceOrderProduct)
                {
                    dgvServiceProduct.Rows.Add(
                        serviceOrderProduct.Product.Name,
                        serviceOrderProduct.Price,
                        serviceOrderProduct.Discount,
                        serviceOrderProduct.Quantity,
                        serviceOrderProduct.Price * serviceOrderProduct.Quantity
                    );
                }
            }
        }

        private void dgvPendingServices_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblServiceCode.Text = @"-";
            lblCustomerCode.Text = @"-";

            if (dgvPendingServices.Rows.Count > 0)
            {
                _selectedServiceOrder = _pendingServiceOrders.First(x => x.Id.ToString() == dgvPendingServices[0, e.RowIndex].Value.ToString());
            }
        }

        private void btnCustomers_Click(object sender, System.EventArgs e)
        {
            var form = _formFactory.CreateForm<PointOfSalesModule.Customer.View>();

            form.ShowDialog();
        }

        private void Dashboard_Load(object sender, System.EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void btnServiceBooking_Click(object sender, System.EventArgs e)
        {
            var form = _formFactory.CreateForm<PointOfSalesModule.ServiceBooking.View>();

            form.ShowDialog();
        }
    }
}