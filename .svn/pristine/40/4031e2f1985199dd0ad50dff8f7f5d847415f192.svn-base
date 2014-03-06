using System;
using System.Windows.Forms;
using Macsauto.Domain.SalesModule;
using Macsauto.Infrastructure.Helper.Extension;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Vehicle.Brand
{
    public partial class Add : Form
    {
        private readonly AddPresenter _presenter;
        private string _code;

        public EventHandler<FormTransactionSuccessArgs<VehicleBrand>> FormTransactionSuccess;

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public string Code
        {
            get { return _code; }
            set
            {
                _code = value;

                txtCode.Text = _code;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                txtCode.ShowError(@"Code is required");
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.ShowError(@"Name is required");
            }
            else
            {
                try
                {
                    var newBrand = _presenter.Save(txtCode.Text, txtName.Text);

                    MessageBox.Show(@"New brand added");

                    OnFormTransactionSuccess(newBrand, true);

                    Dispose(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        protected virtual void OnFormTransactionSuccess(VehicleBrand brand, bool status)
        {
            var handler = FormTransactionSuccess;

            if (handler != null)
            {
                handler(this, new FormTransactionSuccessArgs<VehicleBrand>(brand, true));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
