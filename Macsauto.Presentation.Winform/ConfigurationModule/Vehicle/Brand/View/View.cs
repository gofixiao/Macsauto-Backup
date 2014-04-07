using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Macsauto.Domain.SalesModule;
using Macsauto.Infrastructure.Helper.Extension;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Vehicle.Brand
{
    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private readonly FormFactory _formFactory;
        private IList<VehicleBrand> _brands;
        private IList<VehicleModel> _models;

        public View(ViewPresenter presenter, FormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<VehicleBrand> Brands
        {
            get { return _brands; }
            set
            {
                _brands = value;
 
                dgvVehicleBrand.Rows.Clear();

                foreach (var vehicleBrand in _brands)
                {
                    dgvVehicleBrand.Rows.Add(vehicleBrand.Id, vehicleBrand.Code, vehicleBrand.Name);
                }
            }
        }

        public IList<VehicleModel> Models
        {
            get { return _models; }
            set
            {
                _models = value;

                dgvVehicleModel.Rows.Clear();

                foreach (var vehicleModel in _models)
                {
                    dgvVehicleModel.Rows.Add(vehicleModel.Id, vehicleModel.Code, vehicleModel.Name);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var add = _formFactory.CreateForm<Add>();

            add.FormTransactionSuccess += add_FormTransactionSuccess;

            add.ShowDialog();
        }

        private void add_FormTransactionSuccess(object sender, FormTransactionSuccessArgs<VehicleBrand> e)
        {
            _presenter.SetForm(this);
        }

        private void dgvVehicleBrand_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehicleBrand.Rows.Count > 0)
            {
                var selectedBrand = _brands.First(x => x.Id.ToString() == dgvVehicleBrand[0, e.RowIndex].Value.ToString());

                txtCode.Text = selectedBrand.Code;
                txtFullname.Text = selectedBrand.Name;

                _presenter.GetModel(selectedBrand);
            }
        }
    }
}
