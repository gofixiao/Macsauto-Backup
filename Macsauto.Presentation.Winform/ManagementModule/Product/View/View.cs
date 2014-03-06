namespace Macsauto.Presentation.WinForm.ManagementModule.Product
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
        private IList<Product> _products;

        public View(ViewPresenter presenter, IFormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;

                dgvProducts.Rows.Clear();

                foreach (var product in _products)
                {
                    dgvProducts.Rows.Add(
                        product.Id,
                        product.Code,
                        product.Name,
                        product.Description,
                        product.SellPrice,
                        product.Volume,
                        product.CreatedOn.ToString(@"d")
                    );
                }
            }
        }

        private void lblInventoryCodeValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selectedProduct = _products.FirstOrDefault(x => x.Inventory.Code == lblInventoryCodeValue.Text);

            if (selectedProduct != null)
            {
                var viewInventory = _formFactory.CreateForm<ConfigurationModule.Inventory.ViewDetail>();

                viewInventory.SelectedInventory = selectedProduct.Inventory;

                viewInventory.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(@"No product selected", @"Error");
            }
        }

        private void dgvProducts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.Rows.Count > 0)
            {
                var selectedProduct = _products.First(x => x.Id.ToString() == dgvProducts[0, e.RowIndex].Value.ToString());

                lblCode.Text = selectedProduct.Code + @" - " + selectedProduct.Name;
                lblDescriptionValue.Text = selectedProduct.Description;
                lblVolumeValue.Text = selectedProduct.Volume.ToString(CultureInfo.InvariantCulture);
                lblSellPriceValue.Text = selectedProduct.SellPrice.ToString(CultureInfo.InvariantCulture);
                //lblCreatedByValue.Text = selectedMerchandise.CreatedBy.ToString();
                lblCreatedOnValue.Text = selectedProduct.CreatedOn.ToString(@"d");
                lblInventoryCodeValue.Text = selectedProduct.Inventory.Code;
                lblInventoryNameValue.Text = selectedProduct.Inventory.Name;
                lblInventoryTotalStockValue.Text = _presenter.GetTotalStock(selectedProduct.Inventory).ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}