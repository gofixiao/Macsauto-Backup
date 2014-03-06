namespace Macsauto.Presentation.WinForm.ConfigurationModule.Branch
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.UserManagementModule;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Presentation.WinForm.ConfigurationModule.Inventory;

    public partial class ViewAll : Form
    {
        private readonly ViewAllPresenter _presenter;
        private readonly IFormFactory _formFactory;
        private IList<Branch> _branches;

        public ViewAll(ViewAllPresenter presenter, IFormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<Branch> Branches
        {
            get { return _branches; }
            set
            {
                _branches = value;

                dgvBranches.Rows.Clear();

                foreach (var branch in _branches)
                {
                    dgvBranches.Rows.Add(
                        branch.Id,
                        branch.Code,
                        branch.Name,
                        branch.Address.AddressLine,
                        branch.Address.City,
                        branch.Address.City.Province,
                        branch.Address.Zipcode
                    );
                }
            }
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
            var add = _formFactory.CreateForm<QuickAdd>();

            add.FormTransactionSuccess += AddOnFormTransactionSuccess;

            add.ShowDialog();
        }

        private void AddOnFormTransactionSuccess(object sender, FormTransactionSuccessArgs<Inventory> formTransactionSuccessArgs)
        {
            _presenter.SetForm(this);
        }

        private void dgvBranches_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var view = _formFactory.CreateForm<View>();

            view.Branch = _branches.FirstOrDefault(x => x.Id.ToString() == dgvBranches[0, e.RowIndex].Value.ToString());
        }
    }
}