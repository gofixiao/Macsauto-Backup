namespace Macsauto.Presentation.WinForm.ConfigurationModule.ProductCategory
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;

    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private readonly FormFactory _formFactory;
        private IList<ProductCategory> _productCategories;

        public View(ViewPresenter presenter, FormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<ProductCategory> ProductCategories
        {
            get { return _productCategories; }
            set
            {
                _productCategories = value;

                dgvCategories.Rows.Clear();

                foreach (var productCategory in _productCategories)
                {
                    dgvCategories.Rows.Add(
                        productCategory.Id.ToString(),
                        productCategory.Code,
                        productCategory.Name,
                        productCategory.Description
                    );
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var add = _formFactory.CreateForm<Add>();

            add.FormTransactionSuccess += add_FormTransactionSuccess;

            add.ShowDialog();
        }

        private void add_FormTransactionSuccess(object sender, FormTransactionSuccessArgs<ProductCategory> e)
        {
            _presenter.SetForm(this);
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }
    }
}