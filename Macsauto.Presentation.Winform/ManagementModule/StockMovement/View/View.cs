namespace Macsauto.Presentation.WinForm.ManagementModule.StockMovement
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;

    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private IList<StockMovement> _stockMovements;

        public View(ViewPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<StockMovement> StockMovements
        {
            get { return _stockMovements; }
            set
            {
                _stockMovements = value;

                dgvStockMovements.Rows.Clear();

                foreach (var stockMovement in _stockMovements)
                {
                    dgvStockMovements.Rows.Add(
                        stockMovement.Id,
                        stockMovement.Code,
                        stockMovement.CreatedBy,
                        stockMovement.Type.ToString(),
                        stockMovement.Reference,
                        stockMovement.Remark,
                        stockMovement.CreatedOn.ToString(@"f")
                    );
                }
            }
        }

        private void dgvStockMovements_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStockMovements.Rows.Count > 0)
            {
                lblCode.Text = @"-";
                
                dgvStockMovementItems.Rows.Clear();

                var selectedMovement = _stockMovements.FirstOrDefault(x => x.Id.ToString() == dgvStockMovements[0, e.RowIndex].Value.ToString());

                if (selectedMovement != null)
                {
                    lblCode.Text = selectedMovement.Code;

                    foreach (var item in selectedMovement.StockMovementItems)
                    {
                        dgvStockMovementItems.Rows.Add(
                            item.StockMovement.Id,
                            item.Inventory.Id,
                            item.Inventory.Code,
                            item.Inventory.Name,
                            item.Quantity,
                            item.PreviousStock,
                            item.CurrentStock
                        );
                    }
                }
            }
        }
    }
}