using System;
using System.Windows.Forms;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.ServiceCategory
{
    using Macsauto.Domain.SalesModule;

    public partial class Add : Form
    {
        private readonly AddPresenter _presenter;

        public event EventHandler<FormTransactionSuccessArgs<ServiceCategory>> FormTransactionSuccess;

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public string Code
        {
            get { return txtCode.Text; }
        }

        public string CategoryName
        {
            get { return txtName.Text; }
        }

        public string CategoryDescription
        {
            get { return txtDescription.Text; }
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
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
                var serviceCategory = _presenter.Save();

                MessageBox.Show(@"New service category added");

                OnFormTransactionSuccess(new FormTransactionSuccessArgs<ServiceCategory>(serviceCategory, true));

                Dispose(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OnFormTransactionSuccess(FormTransactionSuccessArgs<ServiceCategory> e)
        {
            var handler = FormTransactionSuccess;

            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}