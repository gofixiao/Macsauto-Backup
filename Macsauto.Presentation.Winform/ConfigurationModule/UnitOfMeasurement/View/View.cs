namespace Macsauto.Presentation.WinForm.ConfigurationModule.UnitOfMeasurement
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;

    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private readonly FormFactory _formFactory;
        private IList<UnitOfMeasurement> _unitOfMeasurements;

        public View(ViewPresenter presenter, FormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<UnitOfMeasurement> UnitOfMeasurements
        {
            get { return _unitOfMeasurements; }
            set
            {
                _unitOfMeasurements = value;

                dgvUoM.Rows.Clear();

                foreach (var uom in _unitOfMeasurements)
                {
                    dgvUoM.Rows.Add(
                        uom.Id,
                        uom.Name,
                        uom.Description
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

        private void add_FormTransactionSuccess(object sender, FormTransactionSuccessArgs<Domain.SalesModule.UnitOfMeasurement> e)
        {
            _presenter.SetForm(this);
        }
    }
}