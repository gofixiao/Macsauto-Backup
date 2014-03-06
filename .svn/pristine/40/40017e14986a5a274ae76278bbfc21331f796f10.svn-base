namespace Macsauto.Presentation.WinForm.ConfigurationModule.Storage
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Linq;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.Helper.Extension;

    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private readonly FormFactory _formFactory;
        private IList<Storage> _storages;

        public View(ViewPresenter presenter, FormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<Storage> Storages
        {
            get { return _storages; }
            set
            {
                _storages = value;

                dgvStorages.Rows.Clear();

                foreach (var storage in _storages)
                {
                    dgvStorages.Rows.Add(
                        storage.Id.ToString(), 
                        storage.Code, 
                        storage.Name
                    );
                }
            }
        }

        public string SelectedStorageId
        {
            get
            {
                return dgvInventories.SelectedCells.Count == 0
                           ? null
                           : dgvInventories.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dgvInventories_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var add = _formFactory.CreateForm<Add>();

            add.FormTransactionSuccess += add_FormTransactionSuccess;

            add.ShowDialog();
        }

        private void add_FormTransactionSuccess(object sender, FormTransactionSuccessArgs<Storage> e)
        {
            _presenter.SetForm(this);
        }

        private void dgvStorages_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStorages.SelectedCells.Count > 0)
            {
                var storage = _storages.First(x => x.Id.ToString() == dgvStorages.Rows[e.RowIndex].Cells[0].Value.ToString());

                dgvInventories.Rows.Clear();

                Controls.ClearContent();

                if (storage != null)
                {
                    txtCode.Text = storage.Code;
                    txtFullname.Text = storage.Name;
                    txtDescription.Text = storage.Description;

                    foreach (var storedInventory in storage.StoredInventories)
                    {
                        dgvInventories.Rows.Add(
                            storedInventory.Inventory.Id.ToString(),
                            storedInventory.Inventory.Code,
                            storedInventory.Inventory.Name,
                            storedInventory.Stock,
                            storedInventory.Inventory.UoM.Name
                        );
                    }
                }
            }
        }
    }
}