using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Macsauto.Domain.SalesModule;
using Macsauto.Infrastructure.Helper.Extension;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Vehicle.Model
{
    public partial class Add : Form
    {
        private readonly AddPresenter _presenter;

        public EventHandler<FormTransactionSuccessArgs<VehicleModel>> FormTransactionSuccess;
        private IList<VehicleBrand> _vehicleBrands;

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);

            cboSize.DataSource = Enum.GetValues(typeof (VehicleSize));
        }

        public IList<VehicleBrand> VehicleBrands
        {
            get { return _vehicleBrands; }
            set
            {
                _vehicleBrands = value;

                cboBrand.Items.Clear();

                foreach (VehicleBrand vehicleBrand in _vehicleBrands)
                {
                    cboBrand.Items.Add(vehicleBrand.Name);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        protected virtual void OnFormTransactionSuccess(VehicleModel model, bool status)
        {
            EventHandler<FormTransactionSuccessArgs<VehicleModel>> handler = FormTransactionSuccess;

            if (handler != null)
            {
                handler(this, new FormTransactionSuccessArgs<VehicleModel>(model, true));
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                txtCode.ShowError(@"Code is required");
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.ShowError(@"Name is required");
            }
            else if (cboBrand.SelectedItem == null)
            {
                cboBrand.ShowError(@"Brand is required");
            }
            else if (!radCar.Checked && !radMotorcycle.Checked)
            {
                MessageBox.Show(@"Type is required");
            }
            else if (cboSize.SelectedItem == null)
            {
                cboSize.ShowError(@"Size is required");
            }
            else
            {
                try
                {
                    VehicleSize size;
                    VehicleBrand brand = _vehicleBrands.First(x => x.Name == cboBrand.SelectedItem.ToString());

                    Enum.TryParse(cboSize.SelectedItem.ToString(), true, out size);

                    var newModel = _presenter.Save(
                        txtCode.Text,
                        txtName.Text,
                        brand,
                        size,
                        radCar.Checked ? VehicleType.CAR : VehicleType.MOTORCYCLE
                        );

                    MessageBox.Show(@"New vehicle model added");

                    OnFormTransactionSuccess(newModel, true);

                    Dispose(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}