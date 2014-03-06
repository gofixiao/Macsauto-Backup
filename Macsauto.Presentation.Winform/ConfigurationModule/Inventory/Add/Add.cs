namespace Macsauto.Presentation.WinForm.ConfigurationModule.Inventory
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
        private IList<ProductCategory> _productCategories;
        private IList<UnitOfMeasurement> _unitOfMeasurements;

        public event EventHandler<FormTransactionSuccessArgs<Inventory>> FormTransactionSuccess;

        protected virtual void OnFormTransactionSuccess(FormTransactionSuccessArgs<Inventory> e)
        {
            var handler = FormTransactionSuccess;

            if (handler != null) handler(this, e);
        }

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<UnitOfMeasurement> UnitOfMeasurements
        {
            get { return _unitOfMeasurements; }
            set
            {
                _unitOfMeasurements = value;

                cboUoM.Items.Clear();

                foreach (var unitOfMeasurement in _unitOfMeasurements)
                {
                    cboUoM.Items.Add(unitOfMeasurement.Code);
                }
            }
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

        public IList<ProductCategory> ProductCategories
        {
            get { return _productCategories; }
            set
            {
                _productCategories = value;

                cboProductCategory.Items.Clear();

                foreach (var productCategory in _productCategories)
                {
                    cboProductCategory.Items.Add(productCategory.Name);
                }
            }
        }

        public string Code { get { return txtCode.Text; } }

        public string InventoryName { get { return txtName.Text; } }

        public string Description { get { return txtDescription.Text; } }

        public UnitOfMeasurement UnitOfMeasurement { get { return _unitOfMeasurements.First(x => x.Code == cboUoM.SelectedItem.ToString()); } }

        public bool AddAsProduct { get { return chkCreateProduct.Checked; } }

        public bool AddAsMerchandise { get { return chkCreateMerchandise.Checked; } }

        public IList<InventoryStorageDto> InventoryStorageDto
        {
            get
            {
                var dtos = new List<InventoryStorageDto>();

                foreach (DataGridViewRow row in dgvStorage.Rows)
                {
                    var storage = _storages.First(x => x.Id.ToString() == row.Cells[0].Value.ToString());
                    var quantity = long.Parse(row.Cells[3].Value.ToString());

                    dtos.Add(new InventoryStorageDto(storage, quantity));
                }

                return dtos;
            }
        }

        public string ProductCode { get { return txtProductCode.Text; } }

        public ProductCategory ProductCategory
        {
            get { return _productCategories.First(x => x.Name == cboProductCategory.SelectedItem.ToString()); }
        }

        public long SellPrice { get { return long.Parse(txtSellPrice.Text); } }

        public long BuyPrice { get { return long.Parse(txtBuyPrice.Text); } }

        public long Volume { get { return long.Parse(txtVolume.Text); } }

        public string MerchandiseCode { get { return txtMerchandiseCode.Text; } }

        public long MerchandisePoint { get { return long.Parse(txtPointCost.Text); } }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void chkCreateProduct_CheckedChanged(object sender, EventArgs e)
        {
            detailProductPanel.Expanded = chkCreateProduct.Checked;
            detailProductPanel.Enabled = chkCreateProduct.Checked;
        }

        private void chkCreateMerchandise_CheckedChanged(object sender, EventArgs e)
        {
            detailMerchandisePanel.Expanded = chkCreateMerchandise.Checked;
            detailMerchandisePanel.Enabled = chkCreateMerchandise.Checked;
        }

        private void btnRemove_Click(object sender, EventArgs e)
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
            if (detailStoragePanel.Controls.ValidateInput(errorProvider))
            {
                var selectedStorage = _storages.First(x => x.Name == cboStorage.SelectedItem.ToString());
                var isExist = false;

                foreach (var row in dgvStorage.Rows.Cast<DataGridViewRow>().Where(row => row.Cells[0].Value.ToString() == selectedStorage.Id.ToString()))
                {
                    isExist = true;
                    row.Cells[3].Value = (long.Parse(row.Cells[3].Value.ToString()) + long.Parse(txtQuantity.Text)).ToString(CultureInfo.InvariantCulture);
                }

                if (!isExist)
                {
                    dgvStorage.Rows.Add(selectedStorage.Id, selectedStorage.Code, selectedStorage.Name, txtQuantity.Text);
                }
            }

            btnRemove.Enabled = dgvStorage.Rows.Count > 0;
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
                var passed = pnlDetailTop.Controls.ValidateInput(errorProvider);

                if (chkCreateProduct.Checked)
                {
                    passed = detailProductPanel.Controls.ValidateInput(errorProvider);
                }

                if (chkCreateMerchandise.Checked)
                {
                    passed = detailMerchandisePanel.Controls.ValidateInput(errorProvider);
                }

                if (passed && MessageBox.Show(@"Create new inventory?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var inventory = _presenter.Save();

                    MessageBox.Show(@"New inventory added");

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