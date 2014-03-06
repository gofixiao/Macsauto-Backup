namespace Macsauto.Presentation.WinForm.ConfigurationModule.ServiceCategory
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;

    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private readonly IFormFactory _formFactory;
        private IList<ServiceCategory> _serviceCategories;

        public View(ViewPresenter presenter, IFormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public IList<ServiceCategory> ServiceCategories
        {
            get { return _serviceCategories; }
            set
            {
                _serviceCategories = value;

                dgvCategories.Rows.Clear();

                foreach (var serviceCategory in _serviceCategories)
                {
                    dgvCategories.Rows.Add(
                        serviceCategory.Id,
                        serviceCategory.Code,
                        serviceCategory.Name,
                        serviceCategory.Description
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

        private void add_FormTransactionSuccess(object sender, FormTransactionSuccessArgs<ServiceCategory> e)
        {
            _presenter.SetForm(this);
        }
    }
}
