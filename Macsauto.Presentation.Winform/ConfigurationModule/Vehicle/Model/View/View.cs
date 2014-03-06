using System.Collections.Generic;
using System.Windows.Forms;
using Macsauto.Domain.SalesModule;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Vehicle.Model
{
    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private readonly IFormFactory _formFactory;
        private IList<VehicleModel> _vehicleModels;

        public View(ViewPresenter presenter, IFormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<VehicleModel> VehicleModels
        {
            get { return _vehicleModels; }
            set
            {
                _vehicleModels = value;

                dgvModel.Rows.Clear();

                foreach (VehicleModel vehicleModel in _vehicleModels)
                {
                    dgvModel.Rows.Add(
                        vehicleModel.Id.ToString(),
                        vehicleModel.Code,
                        vehicleModel.Name,
                        vehicleModel.Brand.Name
                    );
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var add = _formFactory.CreateForm<Add>();

            add.FormTransactionSuccess += add_FormTransactionSuccess;

            add.ShowDialog();
        }

        private void add_FormTransactionSuccess(object sender, FormTransactionSuccessArgs<VehicleModel> e)
        {
            _presenter.SetForm(this);
        }
    }
}