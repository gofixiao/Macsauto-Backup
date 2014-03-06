namespace Macsauto.Presentation.WinForm.PointOfSalesModule.ServiceBooking
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Globalization;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using CustomerSelection = Macsauto.Presentation.WinForm.PointOfSalesModule.Customer;
    using Macsauto.Presentation.WinForm.Common.Printing;
    using Macsauto.Presentation.WinForm.PointOfSalesModule.Common;

    public partial class Create : BaseForm
    {
        private readonly CreatePresenter _presenter;
        private readonly IFormFactory _formFactory;
        private VehicleRegistration _vehicleRegistration;
        private IList<Service> _services;
        private IList<ServiceCategory> _serviceCategories;
        private ServiceBooking _serviceBooking;

        public Create(CreatePresenter presenter, IFormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            var customerSelection = _formFactory.CreateForm<CustomerSelection.View>();

            customerSelection.VehicleSelection += (sender, args) =>
            {
                VehicleRegistration = args.Entity;
            };

            customerSelection.ShowDialog();

            if (_vehicleRegistration == null)
            {
                Dispose();
            }

            _presenter.SetForm(this);
        }

        public Customer Customer
        {
            get { return _vehicleRegistration.RegisteredTo; }
        }

        public IList<Service> Services
        {
            get { return _services; }
            set
            {
                _services = value;
            }
        }

        public VehicleRegistration VehicleRegistration
        {
            get { return _vehicleRegistration; }
            set
            {
                _vehicleRegistration = value;

                lblCustomerCode.Text = Customer.Name.Fullname + @" - " + Customer.MembershipStatus;
                txtFullname.Text = Customer.Name.Fullname;
                txtCellphone.Text = Customer.CellPhone;
                txtEmail.Text = Customer.Email;
                dtpBirthdate.Value = Customer.Birthdate ?? DateTime.Now;

                lblVehicle.Text = _vehicleRegistration.RegisteredVehicle.RegistrationNumber;
                txtVehicleBrand.Text = _vehicleRegistration.RegisteredVehicle.Model.Brand.ToString();
                txtVehicleModel.Text = _vehicleRegistration.RegisteredVehicle.Model.ToString();
                txtVehicleColor.Text = _vehicleRegistration.RegisteredVehicle.Color;
                txtCurrentKm.Text = _vehicleRegistration.RegisteredVehicle.CurrentKM.ToString(CultureInfo.InvariantCulture);
            }
        }

        public IList<ServiceCategory> ServiceCategories
        {
            get { return _serviceCategories; }
            set
            {
                _serviceCategories = value;

                foreach (var serviceCategoryButton in _serviceCategories.Select(serviceCategory => GetButton(serviceCategory.Code, serviceCategory.Code, 253, 190, 17)))
                {
                    serviceCategoryButton.Click += serviceCategoryButton_Click;

                    pnlServiceCategoryList.Controls.Add(serviceCategoryButton);
                }
            }
        }

        public IList<ServiceBookingDto> ServiceBookingDtos
        {
            get
            {
                return (
                    from DataGridViewRow row in dgvServices.Rows 
                    select new ServiceBookingDto(
                        _services.First(service => service.Id.ToString() == row.Cells[0].Value.ToString()), 
                        long.Parse(row.Cells[@"dgvColServicePrice"].Value.ToString()))
                    ).ToList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void serviceCategoryButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            pnlServiceList.Controls.Clear();

            if (button == null) return;

            foreach (var service in _services.Where(service => service.Category.Code == button.Name.Substring(@"button".Length)))
            {
                var serviceButtonText = service.Code + 
                                        Environment.NewLine +
                                        service.GetPriceForVehicle(_vehicleRegistration.RegisteredVehicle).ToString(@"C");
                var serviceButton = GetButton(service.Code, serviceButtonText, button.BackColor.R, button.BackColor.G, button.BackColor.B);

                serviceButton.Click += serviceButton_Click;

                pnlServiceList.Controls.Add(serviceButton);
            }
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            
            if (button == null) return;

            var selectedService = _services.First(service => service.Code == button.Name.Substring(@"button".Length));

            dgvServices.Rows.Add(
                selectedService.Id,
                selectedService.Code,
                selectedService.Name,
                selectedService.Description,
                selectedService.Category.Name,
                selectedService.GetPriceForVehicle(_vehicleRegistration.RegisteredVehicle),
                0
            );
        }

        private static Button GetButton(string name, string text, int r, int g, int b)
        {
            var button = new Button
                {
                    BackColor = Color.FromArgb(r, g, b),
                    Dock = DockStyle.Top,
                    Name = @"button" + name,
                    Size = new Size(125, 90),
                    TabIndex = 0,
                    Text = text,
                    UseVisualStyleBackColor = false
                };

            return button;
        }

        private void CountTotal()
        {
            var total = dgvServices.Rows.Cast<DataGridViewRow>().Sum(row => long.Parse(row.Cells[@"dgvColServicePrice"].Value.ToString()));

            lblTotalPrice.Text = total.ToString(@"C");
        }

        private void dgvServices_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CountTotal();
        }

        private void dgvServices_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CountTotal();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvServices.Rows.Count == 0)
            {
                MessageBox.Show(@"No service selected");
            }
            else
            {
                var paymentForm = _formFactory.CreateForm<PointOfSalesModule.Payment.Create>();

                paymentForm.FinalizingPayment += paymentForm_FinalizingPayment;
                //paymentForm.FormTransactionSuccess += paymentForm_FormTransactionSuccess;

                paymentForm.Charged = dgvServices.Rows.Cast<DataGridViewRow>().Sum(row => long.Parse(row.Cells[@"dgvColServicePrice"].Value.ToString()));

                paymentForm.ShowDialog();
            }
        }

        private void paymentForm_FormTransactionSuccess(object sender, FormTransactionSuccessArgs<Payment> e)
        {
            //OnFormTransactionSuccess(new FormTransactionSuccessArgs<ServiceBooking>(_serviceBooking, true));

            MessageBox.Show(@"Transaction success");

            using (var printer = new LocalReportPrinter(@"PointOfSalesModule\ServiceBooking\Create\Receipt.rdlc"))
            {
                printer.AddDataSource(@"ServiceBooking", new List<ServiceBooking>{ _serviceBooking });

                printer.Run();
            }

            Dispose();
        }

        private void paymentForm_FinalizingPayment(object sender, EventArgs e)
        {
            var paymentForm = sender as PointOfSalesModule.Payment.Create;
            
            _serviceBooking = _presenter.Save();

            if (paymentForm == null) return;

            paymentForm.Transaction = _serviceBooking;
        }

        private void dgvServices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServices.Columns[e.ColumnIndex].ReadOnly == false)
            {
                
            }
        }
    }
}