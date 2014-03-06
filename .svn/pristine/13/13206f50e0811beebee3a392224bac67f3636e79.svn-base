namespace Macsauto.Presentation.WinForm.ConfigurationModule.ServiceCategory
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;

    public partial class ViewDetail : Form
    {
        private readonly ViewDetailPresenter _presenter;
        private ServiceCategory _serviceCategory;
        private IList<Service> _services;

        public ViewDetail(ViewDetailPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }

        public ServiceCategory ServiceCategory
        {
            get { return _serviceCategory; }
            set
            {
                _serviceCategory = value;

                Text = @"Inventory - " + _serviceCategory.Code;

                txtCode.Text = _serviceCategory.Code;
                txtFullname.Text = _serviceCategory.Name;
                txtDescription.Text = _serviceCategory.Description;
            }
        }

        public IList<Service> Services
        {
            get { return _services; }
            set
            {
                _services = value;

                dgvServices.Rows.Clear();

                foreach (var service in _services)
                {
                    dgvServices.Rows.Add(
                        service.Id,
                        service.Code,
                        service.Name,
                        service.Description
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

        private void ViewDetail_Load(object sender, System.EventArgs e)
        {
            if (_serviceCategory == null)
            {
                throw new ApplicationException(@"Selected service is not set");
            }

            _presenter.SetForm(this);
        }
    }
}
