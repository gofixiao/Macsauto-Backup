namespace Macsauto.Presentation.WinForm.ManagementModule.Merchandise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.Helper.Extension;

    public partial class AddFromInventory : Form
    {
        private readonly AddFromInventoryPresenter _presenter;
        private IList<Inventory> _inventories;

        public event EventHandler<FormTransactionSuccessArgs<Merchandise>> FormTransactionSuccess;

        protected virtual void OnFormTransactionSuccess(FormTransactionSuccessArgs<Merchandise> e)
        {
            var handler = FormTransactionSuccess;
            if (handler != null) handler(this, e);
        }

        public AddFromInventory(AddFromInventoryPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<Inventory> Inventories
        {
            get { return _inventories; }
            set
            {
                _inventories = value;

                cboInventory.Items.Clear();

                foreach (var inventory in _inventories)
                {
                    cboInventory.Items.Add(inventory.Name);
                }
            }
        }

        public Inventory SelectedInventory
        {
            get { return _inventories.FirstOrDefault(x => x.Name == cboInventory.SelectedItem.ToString()); }
        }

        public string MerchandiseCode { get { return txtCode.Text; } }

        public string MerchandiseName { get { return txtName.Text; } }

        public string MerchandiseDescription { get { return txtDescription.Text; } }

        public long MerchandisePointCost { get { return long.Parse(txtPointCost.Text); } }

        public long MerchandiseVolume { get { return long.Parse(txtVolume.Text); } }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Save();
        }

        private void saveToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                if (pnlDetail.Controls.ValidateInput(errorProvider) && MessageBox.Show(@"Create new merchandise?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var merchandise = _presenter.Save();

                    MessageBox.Show(@"Merchandise added");

                    OnFormTransactionSuccess(new FormTransactionSuccessArgs<Merchandise>(merchandise, true));

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