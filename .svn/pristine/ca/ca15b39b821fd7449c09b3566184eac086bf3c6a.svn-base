namespace Macsauto.Presentation.WinForm.ManagementModule.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Domain.Shared;
    using Macsauto.Infrastructure.Helper.Extension;

    public partial class Add : Form
    {
        private readonly AddPresenter _presenter;
        private string _customerCode;
        private IList<VehicleBrand> _vehicleBrands;
        private IList<VehicleModel> _vehicleModels;
        private IList<Province> _provinces;
        private IList<City> _cities;

        public EventHandler<FormTransactionSuccessArgs<Customer>> FormTransactionSuccess;

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public string CustomerCode
        {
            get { return _customerCode; }
            set
            {
                _customerCode = value;

                txtCode.Text = _customerCode;
            }
        }

        public string Firstname { get { return txtFirstname.Text; } }

        public string Middlename { get { return txtMiddlename.Text; } }

        public string Lastname { get { return txtLastname.Text; } }

        public string AddressLine { get { return txtAddressLine.Text; } }

        public string Zipcode { get { return txtZipcode.Text; } }

        public City City
        {
            get
            {
                return cboCity.SelectedItem != null ? _cities.First(x => x.Name == cboCity.SelectedItem.ToString()) : null;
            }
        }

        public Province Province
        {
            get
            {
                return cboProvince.SelectedItem != null ? _provinces.First(x => x.Name == cboProvince.SelectedItem.ToString()) : null;
            }
        }

        public IList<Vehicle> Vehicles
        {
            get 
            { 
                var vehicles = new List<Vehicle>();

                foreach (DataGridViewRow row in dgvVehicleInfo.Rows)
                {
                    var registrationNumber = row.Cells[0].Value.ToString();
                    var model = _vehicleModels.First(x => x.Name == row.Cells[2].Value.ToString());
                    var color = row.Cells[4].Value.ToString();
                    var currentKm = long.Parse(row.Cells[5].Value.ToString());

                    vehicles.Add(new Vehicle(registrationNumber, model, color, currentKm));
                }

                return vehicles;
            }
        }

        public bool WantsToBeAMember { get { return chkIsMember.Checked; } }

        public IList<VehicleBrand> VehicleBrands
        {
            get { return _vehicleBrands; }
            set
            {
                _vehicleBrands = value;

                cboBrand.Items.Clear();
                cboModel.Items.Clear();

                foreach (VehicleBrand vehicleBrand in _vehicleBrands)
                {
                    cboBrand.Items.Add(vehicleBrand.Name);
                }
            }
        }

        public IList<VehicleModel> VehicleModels
        {
            get { return _vehicleModels; }
            set
            {
                _vehicleModels = value;

                cboModel.Items.Clear();

                foreach (VehicleModel vehicleModel in _vehicleModels)
                {
                    cboModel.Items.Add(vehicleModel.Name);
                }
            }
        }

        public IList<Province> Provinces
        {
            get { return _provinces; }
            set
            {
                _provinces = value;

                cboProvince.Items.Clear();
                cboCity.Items.Clear();

                foreach (Province province in _provinces)
                {
                    cboProvince.Items.Add(province.Name);
                }
            }
        }

        public IList<City> Cities
        {
            get { return _cities; }
            set
            {
                _cities = value;

                cboCity.Items.Clear();

                foreach (City city in _cities)
                {
                    cboCity.Items.Add(city.Name);
                }
            }
        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBrand.SelectedItem != null)
            {
                VehicleBrand selectedBrand = _vehicleBrands.First(x => x.Name == cboBrand.SelectedItem.ToString());

                _presenter.GetModel(selectedBrand);
            }
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModel.SelectedItem != null)
            {
                VehicleModel selectedModel = _vehicleModels.First(x => x.Name == cboModel.SelectedItem.ToString());

                txtSize.Text = selectedModel.Size.ToString();
            }
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvince.SelectedItem != null)
            {
                Province selectedProvince = _provinces.First(x => x.Name == cboProvince.SelectedItem.ToString());

                _presenter.GetCity(selectedProvince);
            }
        }

        protected virtual void OnFormTransactionSuccess(Customer customer, bool status)
        {
            EventHandler<FormTransactionSuccessArgs<Customer>> handler = FormTransactionSuccess;

            if (handler != null)
                handler(this, new FormTransactionSuccessArgs<Customer>(customer, status));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegistrationNumber.Text))
            {
                txtRegistrationNumber.ShowError(@"Vehicle registration number is required");
            }
            else if (cboBrand.SelectedItem == null)
            {
                cboBrand.ShowError(@"Vehicle brand is required");
            }
            else if (cboModel.SelectedItem == null)
            {
                cboModel.ShowError(@"Vehicle model is required");
            }
            else if (string.IsNullOrEmpty(txtColor.Text))
            {
                txtColor.ShowError(@"Vehicle color is required");
            }
            else
            {
                dgvVehicleInfo.Rows.Add(
                    txtRegistrationNumber.Text,
                    cboBrand.SelectedItem.ToString(),
                    cboModel.SelectedItem.ToString(),
                    txtSize.Text,
                    txtColor.Text,
                    txtCurrentKM.Text
                    );
            }

            btnRemove.Enabled = dgvVehicleInfo.Rows.Count > 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvVehicleInfo.SelectedRows.Count > 0)
            {
                dgvVehicleInfo.Rows.RemoveAt(dgvVehicleInfo.SelectedCells[0].RowIndex);
            }
            else
            {
                MessageBox.Show(@"No row selected");
            }

            btnRemove.Enabled = dgvVehicleInfo.Rows.Count > 0;
        }

        private void fileSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            errorProvider.Clear();

            bool isPassed = new Control[]
                {
                    txtFirstname,
                    txtCellphone
                }.ValidateInput(errorProvider);

            if (!(string.IsNullOrEmpty(txtAddressLine.Text) && 
                cboProvince.SelectedItem == null &&
                cboCity.SelectedItem == null && 
                string.IsNullOrEmpty(txtZipcode.Text)))
            {
                isPassed = gbxAddressInformation.Controls.ValidateInput(errorProvider);
            }

            if (chkIsMember.Checked)
            {
                isPassed = radMale.Checked || radFemale.Checked;
            }

            if (isPassed && MessageBox.Show(@"Create new customer?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {               
                var newCustomer = _presenter.Save();

                MessageBox.Show(@"New customer added");

                OnFormTransactionSuccess(newCustomer, true);

                Dispose(true);
            }
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