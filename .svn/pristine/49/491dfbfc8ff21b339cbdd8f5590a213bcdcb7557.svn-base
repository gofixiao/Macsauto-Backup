using System;
using System.Windows.Forms;
using Macsauto.Infrastructure.Crosscutting;
using Macsauto.Infrastructure.Helper.Extension;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Storage
{
    public partial class Add : Form
    {
        private readonly AddPresenter _presenter;

        public event EventHandler<FormTransactionSuccessArgs<Domain.SalesModule.Storage>> FormTransactionSuccess;

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public string StorageCode
        {
            get { return txtCode.Text; }
        }

        public string StorageName
        {
            get { return txtName.Text; }
        }

        public string StorageDescription
        {
            get { return txtDescription.Text; }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void Save()
        {
            errorProvider.Clear();

            bool isPassed = pnlDetail.Controls.ValidateInput(errorProvider);

            if (isPassed)
            {
                try
                {
                    var storage = _presenter.Save();

                    MessageBox.Show(@"New storage created");

                    OnFormTransactionSuccess(storage, true);

                    Dispose(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        protected virtual void OnFormTransactionSuccess(Domain.SalesModule.Storage storage, bool status)
        {
            EventHandler<FormTransactionSuccessArgs<Domain.SalesModule.Storage>> handler = FormTransactionSuccess;

            if (handler != null) handler(this, new FormTransactionSuccessArgs<Domain.SalesModule.Storage>(storage, status));
        }
    }
}