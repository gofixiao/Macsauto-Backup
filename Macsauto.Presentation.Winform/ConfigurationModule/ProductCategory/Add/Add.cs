using Macsauto.Infrastructure.Helper.Extension;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.ProductCategory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;

    public partial class Add : Form
    {
        private readonly AddPresenter _presenter;
        private IList<ProductCategory> _productCategories;

        public event EventHandler<FormTransactionSuccessArgs<ProductCategory>> FormTransactionSuccess;

        public void OnFormTransactionSuccess(FormTransactionSuccessArgs<ProductCategory> e)
        {
            var handler = FormTransactionSuccess;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public string Code { get { return txtCode.Text; } }

        public string CategoryName { get { return txtName.Text; } }

        public string CategoryDescription { get { return txtDescription.Text; } }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Save();
        }

        private void saveToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                bool isPassed = new Control[]
                    {
                        txtCode,
                        txtDescription,
                        txtName
                    }.ValidateInput(errorProvider);

                if (isPassed && MessageBox.Show(@"Create new product category?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var productCategory = _presenter.Save();

                    MessageBox.Show(@"New product category added");

                    OnFormTransactionSuccess(new FormTransactionSuccessArgs<ProductCategory>(productCategory, true));

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