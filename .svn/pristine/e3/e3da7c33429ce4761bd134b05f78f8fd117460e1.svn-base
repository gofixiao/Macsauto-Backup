namespace Macsauto.Presentation.WinForm.ConfigurationModule.Inventory
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;

    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private readonly IFormFactory _formFactory;
        private IList<Inventory> _inventories;
        private IList<Storage> _storages;
        private Inventory _selectedInventory;

        public View(ViewPresenter presenter, IFormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<Inventory> Inventories
        {
            get { return _inventories; }
            set
            {
                _inventories = value;

                dgvInventories.Rows.Clear();

                foreach (var inventory in _inventories)
                {
                    dgvInventories.Rows.Add(
                        inventory.Id.ToString(),
                        inventory.Code,
                        inventory.Name
                    );
                }
            }
        }

        public IList<Storage> Storages
        {
            get { return _storages; }
            set
            {
                _storages = value;

                dgvStorages.Rows.Clear();

                long totalStock = 0;

                foreach (var storage in _storages)
                {
                    var stock = storage.GetStockOf(_selectedInventory);

                    totalStock += stock;

                    dgvStorages.Rows.Add(
                        storage.Id.ToString(),
                        storage.Code,
                        storage.Name,
                        stock
                    );
                }

                txtTotalStock.Text = totalStock.ToString(CultureInfo.InvariantCulture);
            }
        }

        public Inventory SelectedInventory
        {
            get
            {
                return _selectedInventory;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void dgvInventories_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedInventory = null;

            if (dgvInventories.Rows.Count > 0)
            {
                var inventoryId = dgvInventories.Rows[e.RowIndex].Cells[0].Value.ToString();

                _selectedInventory = _inventories.First(x => x.Id.ToString() == inventoryId);

                txtCode.Text = _selectedInventory.Code;
                txtFullname.Text = _selectedInventory.Name;
                txtDescription.Text = _selectedInventory.Description;
                txtMeasurement.Text = _selectedInventory.UoM.Name;
            }

            _presenter.GetInventoryStocks();
        }

        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var add = _formFactory.CreateForm<Add>();

            add.FormTransactionSuccess += AddOnFormTransactionSuccess;

            add.ShowDialog();
        }

        private void AddOnFormTransactionSuccess(object sender, FormTransactionSuccessArgs<Inventory> formTransactionSuccessArgs)
        {
            _presenter.SetForm(this);
        }
    }
}