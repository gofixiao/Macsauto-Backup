namespace Macsauto.Presentation.WinForm.ConfigurationModule.UnitOfMeasurement
{
    using System;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.Helper.Extension;

    public partial class Add : Form
    {
        private readonly AddPresenter _presenter;

        public event EventHandler<FormTransactionSuccessArgs<UnitOfMeasurement>> FormTransactionSuccess;

        public void OnFormTransactionSuccess(FormTransactionSuccessArgs<UnitOfMeasurement> e)
        {
            var handler = FormTransactionSuccess;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public string MeasurementName { get { return txtName.Text; } }

        public string MeasurementDescription { get { return txtDescription.Text; } }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void saveToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Save();
        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                if (pnlDetail.Controls.ValidateInput(errorProvider) && MessageBox.Show(@"Create new measurement unit?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var uom = _presenter.Save();

                    MessageBox.Show(@"Unit of measurement added");

                    OnFormTransactionSuccess(new FormTransactionSuccessArgs<UnitOfMeasurement>(uom, true));

                    Dispose(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}