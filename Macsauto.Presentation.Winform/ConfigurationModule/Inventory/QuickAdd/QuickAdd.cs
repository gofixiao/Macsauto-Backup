namespace Macsauto.Presentation.WinForm.ConfigurationModule.Inventory
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.Helper.Extension;

    public partial class QuickAdd : Form
    {
        private readonly QuickAddPresenter _presenter;
        private IList<UnitOfMeasurement> _measurements;

        public event EventHandler<FormTransactionSuccessArgs<Inventory>> FormTransactionSuccess;

        protected virtual void OnFormTransactionSuccess(FormTransactionSuccessArgs<Inventory> e)
        {
            var handler = FormTransactionSuccess;

            if (handler != null) handler(this, e);
        }

        public QuickAdd(QuickAddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<UnitOfMeasurement> Measurements
        {
            get { return _measurements; }
            set
            {
                _measurements = value;

                cboUoM.Items.Clear();

                foreach (var measurement in _measurements)
                {
                    cboUoM.Items.Add(measurement.Name);
                }
            }
        }

        public string InventoryCode
        {
            get { return txtCode.Text; }
        }

        public string InventoryName
        {
            get { return txtName.Text; }
        }

        public string InventoryDescription
        {
            get { return txtDescription.Text; }
        }

        public long InventoryBuyPrice
        {
            get { return long.Parse(txtBuyPrice.Text); }
        }

        public UnitOfMeasurement Measurement
        {
            get { return _measurements.FirstOrDefault(x => x.Name == cboUoM.SelectedItem.ToString()); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                var isPassed = pnlDetail.Controls.ValidateInput(errorProvider);

                if (isPassed && MessageBox.Show(@"Create new inventory?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var inventory = _presenter.Save();

                    MessageBox.Show(@"Inventory is created");

                    OnFormTransactionSuccess(new FormTransactionSuccessArgs<Inventory>(inventory, true));

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