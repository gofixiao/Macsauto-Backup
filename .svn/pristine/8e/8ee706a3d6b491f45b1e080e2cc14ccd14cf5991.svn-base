namespace Macsauto.Presentation.WinForm.ManagementModule.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.Helper.Extension;

    public partial class Add : Form
    {
        private readonly AddPresenter _presenter;
        private IList<ServiceCategory> _serviceCategories;

        public event EventHandler<FormTransactionSuccessArgs<Service>> FormTransactionSuccessArgs;

        protected virtual void OnFormTransactionSuccessArgs(FormTransactionSuccessArgs<Service> e)
        {
            var handler = FormTransactionSuccessArgs;
            if (handler != null) handler(this, e);
        }

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);

            foreach (var vehicleSize in (VehicleSize[])Enum.GetValues(typeof(VehicleSize)))
            {
                dgvServicePricings.Rows.Add(vehicleSize, 0);
            }
        }

        public IList<ServiceCategory> ServiceCategories
        {
            get { return _serviceCategories; }
            set
            {
                _serviceCategories = value;

                cboServiceCategory.Items.Clear();

                foreach (var serviceCategory in _serviceCategories)
                {
                    cboServiceCategory.Items.Add(serviceCategory.Name);
                }
            }
        }

        public string ServiceCode { get { return txtCode.Text; } }

        public string ServiceName { get { return txtName.Text; } }

        public string ServiceDescription { get { return txtDescription.Text; } }

        public ServiceCategory ServiceCategory
        {
            get { return _serviceCategories.FirstOrDefault(x => x.Name == cboServiceCategory.SelectedItem.ToString()); }
        }

        public IList<ServicePricingDto> ServicePricings
        {
            get
            {
                var servicePricings = new List<ServicePricingDto>();

                foreach (DataGridViewRow row in dgvServicePricings.Rows)
                {
                    VehicleSize vehicleSize;

                    Enum.TryParse(row.Cells[0].Value.ToString(), out vehicleSize);

                    servicePricings.Add(
                        new ServicePricingDto(vehicleSize, long.Parse(row.Cells[1].Value.ToString()))
                    );
                }

                return servicePricings;
            }
        }

        public void Save()
        {
            try
            {
                if (pnlDetailTop.Controls.ValidateInput(errorProvider) && MessageBox.Show(@"Create a new service?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var service = _presenter.Save();

                    MessageBox.Show(@"New service created");

                    OnFormTransactionSuccessArgs(new FormTransactionSuccessArgs<Service>(service, true));

                    Dispose(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}