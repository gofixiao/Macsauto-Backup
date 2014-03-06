namespace Macsauto.Presentation.WinForm.ManagementModule.Product
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
        private IList<ProductCategory> _productCategories;

        public event EventHandler<FormTransactionSuccessArgs<Product>> FormTransactionSuccess;

        protected virtual void OnFormTransactionSuccess(FormTransactionSuccessArgs<Product> e)
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

        public string ProductCode { get { return txtCode.Text; } }

        public Inventory SelectedInventory
        {
            get { return _inventories.FirstOrDefault(x => x.Name == cboInventory.SelectedItem.ToString()); }
        }

        public ProductCategory SelectedCategory
        {
            get { return _productCategories.FirstOrDefault(x => x.Name == cboProductCategory.SelectedItem.ToString()); }
        }

        public long ProductSellPrice { get { return long.Parse(txtSellPrice.Text); } }

        public string SelectedProductName { get { return txtName.Text; } }

        public string ProductDescription { get { return txtDescription.Text; } }

        public long Volume { get { return long.Parse(txtVolume.Text); } }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            try
            {
                if (pnlDetail.Controls.ValidateInput(errorProvider) && MessageBox.Show(@"Create new product?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var product = _presenter.Save();

                    MessageBox.Show(@"New product created");

                    OnFormTransactionSuccess(new FormTransactionSuccessArgs<Product>(product, true));

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