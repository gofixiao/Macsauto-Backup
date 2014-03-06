namespace Macsauto.Presentation.WinForm.ManagementModule.StockMovement
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.Helper.Extension;

    public partial class Add : Form
    {
        private readonly AddPresenter _presenter;
        private IList<Storage> _storages;
        private IList<Inventory> _inventories;

        public event EventHandler<FormTransactionSuccessArgs<StockMovement>> FormTransactionSuccess;

        protected virtual void OnFormTransactionSuccess(FormTransactionSuccessArgs<StockMovement> e)
        {
            var handler = FormTransactionSuccess;
            if (handler != null) handler(this, e);
        }

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);

            cboMovementType.DataSource = Enum.GetNames(typeof (StockMovementType));
        }

        public IList<Storage> Storages
        {
            get { return _storages; }
            set
            {
                _storages = value;

                cboStorage.Items.Clear();

                foreach (var storage in _storages)
                {
                    cboStorage.Items.Add(storage.Name);
                }
            }
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

        public StockMovementType StockMovementType
        {
            get
            {
                StockMovementType stockMovementType;

                Enum.TryParse(cboMovementType.SelectedItem.ToString(), out stockMovementType);

                return stockMovementType;
            }
        }

        public string MovementRemark { get { return txtRemark.Text; } }

        public string MovementReference { get { return txtReference.Text; } }

        public IList<StockMovementItemDto> StockMovementItemDtos
        {
            get
            {
                return (
                    from DataGridViewRow row in dgvStorage.Rows 
                    let storage = _storages.FirstOrDefault(x => x.Id.ToString() == row.Cells[0].Value.ToString()) 
                    let inventory = _inventories.FirstOrDefault(x => x.Id.ToString() == row.Cells[3].Value.ToString()) 
                    let quantity = long.Parse(row.Cells[6].Value.ToString()) 
                    select new StockMovementItemDto(storage, inventory, quantity)
                ).ToList();
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

        private void saveToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Save();
        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Save();
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            if (dgvStorage.SelectedRows.Count > 0)
            {
                dgvStorage.Rows.RemoveAt(dgvStorage.SelectedCells[0].RowIndex);
            }
            else
            {
                MessageBox.Show(@"No row selected");
            }

            btnRemove.Enabled = dgvStorage.Rows.Count > 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (gbxDetail.Controls.ValidateInput(errorProvider))
            {
                var selectedStorage = _storages.FirstOrDefault(x => x.Name == cboStorage.SelectedItem.ToString());
                var selectedInventory = _inventories.FirstOrDefault(x => x.Name == cboInventory.SelectedItem.ToString());
                var isExist = false;

                if (selectedStorage != null && selectedInventory != null)
                {
                    foreach (var row in dgvStorage.Rows.Cast<DataGridViewRow>().Where(row => 
                        row.Cells[0].Value.ToString() == selectedStorage.Id.ToString() &&
                        row.Cells[3].Visible.ToString() == selectedInventory.Id.ToString()))
                    {
                        isExist = true;
                        row.Cells[6].Value = (long.Parse(row.Cells[6].Value.ToString()) + long.Parse(txtQuantity.Text)).ToString(CultureInfo.InvariantCulture);
                    }

                    if (!isExist)
                    {
                        dgvStorage.Rows.Add(selectedStorage.Id, selectedStorage.Code, selectedStorage.Name, selectedInventory.Id, selectedInventory.Code, selectedInventory.Name, txtQuantity.Text);
                    }
                }
            }

            btnRemove.Enabled = dgvStorage.Rows.Count > 0;
        }

        private void cboStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStorage = _storages.FirstOrDefault(x => x.Name == cboStorage.SelectedItem.ToString());

            _presenter.GetInventories(selectedStorage);
        }

        private void Save()
        {
            try
            {
                if (cboMovementType.SelectedIndex < 0)
                {
                    errorProvider.SetError(cboMovementType, @"Movement type is required");
                }
                else if (dgvStorage.Rows.Count < 1)
                {
                    MessageBox.Show(@"At least one movement item is required");
                }
                else if (MessageBox.Show(@"Create new stock movement?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var stockMovement = _presenter.Save();

                    MessageBox.Show(@"Stock movement created with code " + stockMovement.Code);

                    OnFormTransactionSuccess(new FormTransactionSuccessArgs<StockMovement>(stockMovement, true));

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