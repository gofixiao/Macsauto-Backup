namespace Macsauto.Presentation.WinForm.ConfigurationModule.Inventory
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;

    public partial class ViewDetail : Form
    {
        private readonly ViewDetailPresenter _presenter;
        private Inventory _selectedInventory;
        private IList<Storage> _storages;
        private IList<StockMovement> _movements;

        public ViewDetail(ViewDetailPresenter presenter)
        {
            _presenter = presenter;
                
            InitializeComponent();
        }

        public Inventory SelectedInventory
        {
            get { return _selectedInventory; }
            set
            {
                _selectedInventory = value;

                Text = @"Inventory - " + _selectedInventory.Code;

                txtCode.Text = _selectedInventory.Code;
                txtFullname.Text = _selectedInventory.Name;
                txtDescription.Text = _selectedInventory.Description;
                txtMeasurement.Text = _selectedInventory.UoM.Name;
            }
        }

        public IList<Storage> Storages
        {
            get { return _storages; }
            set
            {
                _storages = value;

                dgvStocks.Rows.Clear();

                long totalStock = 0;

                foreach (var storage in _storages)
                {
                    var stock = storage.GetStockOf(_selectedInventory);

                    totalStock += stock;

                    dgvStocks.Rows.Add(
                        storage.Id.ToString(),
                        storage.Code,
                        storage.Name,
                        stock
                    );
                }

                txtTotalStock.Text = totalStock.ToString(CultureInfo.InvariantCulture);
            }
        }

        public IList<StockMovement> Movements
        {
            get { return _movements; }
            set
            {
                _movements = value;

                dgvMovement.Rows.Clear();

                foreach (var stockMovement in _movements)
                {
                    foreach (var stockMovementItem in stockMovement.StockMovementItems.Where(x => x.Inventory == _selectedInventory))
                    {
                        dgvMovement.Rows.Add(
                            stockMovement.Id,
                            stockMovement.Code,
                            Enum.GetName(typeof(StockMovementType), stockMovement.Type),
                            stockMovementItem.Storage.Name,
                            stockMovementItem.PreviousStock,
                            stockMovementItem.CurrentStock,
                            stockMovement.CreatedOn.ToString(@"d")
                        );
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void ViewDetail_Load(object sender, EventArgs e)
        {
            if (_selectedInventory == null)
            {
                throw new ApplicationException(@"Selected inventory is not set");
            }

            _presenter.SetForm(this);
        }
    }
}