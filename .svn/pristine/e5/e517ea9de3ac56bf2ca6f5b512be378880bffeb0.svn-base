namespace Macsauto.Presentation.WinForm.ManagementModule.Merchandise
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
        private IList<Merchandise> _merchandises;

        public View(ViewPresenter presenter, IFormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<Merchandise> Merchandises
        {
            get { return _merchandises; }
            set
            {
                _merchandises = value;

                dgvMerchandises.Rows.Clear();

                foreach (var merchandise in _merchandises)
                {
                    dgvMerchandises.Rows.Add(
                        merchandise.Id,
                        merchandise.Code,
                        merchandise.Name,
                        merchandise.Description,
                        merchandise.PointCost,
                        merchandise.Volume,
                        merchandise.CreatedOn
                    );
                }
            }
        }

        private void dgvMerchandises_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMerchandises.Rows.Count > 0)
            {
                var selectedMerchandise = _merchandises.First(x => x.Id.ToString() == dgvMerchandises[0, e.RowIndex].Value.ToString());

                lblCode.Text = selectedMerchandise.Code + @" - " + selectedMerchandise.Name;
                lblDescriptionValue.Text = selectedMerchandise.Description;
                lblPointValue.Text = selectedMerchandise.PointCost.ToString(CultureInfo.InvariantCulture);
                lblVolumeValue.Text = selectedMerchandise.Volume.ToString(CultureInfo.InvariantCulture);
                //lblCreatedByValue.Text = selectedMerchandise.CreatedBy.ToString();
                lblCreatedOnValue.Text = selectedMerchandise.CreatedOn.ToString(@"d");
                lblInventoryCodeValue.Text = selectedMerchandise.Inventory.Code;
                lblInventoryNameValue.Text = selectedMerchandise.Inventory.Name;
                lblInventoryTotalStockValue.Text = _presenter.GetTotalStock(selectedMerchandise.Inventory).ToString(CultureInfo.InvariantCulture);
            }
        }

        private void lblInventoryCodeValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selectedMerchandise = _merchandises.FirstOrDefault(x => x.Inventory.Code == lblInventoryCodeValue.Text);

            if (selectedMerchandise != null)
            {
                var viewInventory = _formFactory.CreateForm<ConfigurationModule.Inventory.ViewDetail>();

                viewInventory.SelectedInventory = selectedMerchandise.Inventory;

                viewInventory.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(@"No merchandise selected", @"Error");
            }
        }
    }
}