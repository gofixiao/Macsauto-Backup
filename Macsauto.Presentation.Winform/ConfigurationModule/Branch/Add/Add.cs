namespace Macsauto.Presentation.WinForm.ConfigurationModule.Branch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.Shared;
    using Macsauto.Domain.UserManagementModule;
    using Macsauto.Infrastructure.Helper.Extension;

    public partial class Add : Form
    {
        private readonly AddPresenter _presenter;
        private IList<Province> _provinces;
        private IList<City> _cities;

        public EventHandler<FormTransactionSuccessArgs<Branch>> FormTransactionSuccess;

        public Add(AddPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public string BranchCode
        {
            set { txtCode.Text = value; }
            get { return txtCode.Text; }
        }

        public string BranchName
        {
            get { return txtName.Text; }
        }

        public string AddressLine
        {
            get { return txtAddressLine.Text; }
        }

        public Province Province
        {
            get { return _provinces.FirstOrDefault(x => x.Name == cboProvince.SelectedItem.ToString()); }
        }

        public City City
        {
            get { return _cities.FirstOrDefault(x => x.Name == cboCity.SelectedItem.ToString()); }
        }

        public string Zipcode
        {
            get { return txtZipcode.Text; }
        }

        public IList<Province> Provinces
        {
            set
            {
                _provinces = value;

                cboProvince.Items.Clear();

                foreach (Province province in _provinces)
                {
                    cboProvince.Items.Add(province.Name);
                }

                cboProvince.SelectedIndex = -1;
            }
        }

        public IList<City> Cities
        {
            set
            {
                _cities = value;

                cboCity.Items.Clear();

                foreach (City city in _cities)
                {
                    cboCity.Items.Add(city.Name);
                }

                cboCity.SelectedIndex = -1;
            }
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvince.SelectedItem != null)
            {
                _presenter.GetCities(_provinces.First(x => x.Name == cboProvince.SelectedItem.ToString()));
            }
        }

        protected virtual void OnFormTransactionSuccess(Branch branch, bool status)
        {
            var handler = FormTransactionSuccess;

            if (handler != null)
                handler(this, new FormTransactionSuccessArgs<Branch>(branch, status));
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
            try
            {
                var passed = headerPanel.Controls.ValidateInput(errorProvider) &&
                         detailPanel.Controls.ValidateInput(errorProvider);

                if (passed && MessageBox.Show(@"Create new branch?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var branch = _presenter.Save();

                    MessageBox.Show(@"New branch created");

                    OnFormTransactionSuccess(branch, true);

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