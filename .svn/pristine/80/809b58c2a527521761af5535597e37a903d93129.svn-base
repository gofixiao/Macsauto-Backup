namespace Macsauto.Presentation.WinForm.ManagementModule.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Presentation.WinForm.ConfigurationModule.ServiceCategory;

    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private readonly IFormFactory _formFactory;
        private IList<Service> _services;

        public View(ViewPresenter presenter, IFormFactory formFactory)
        {
            _presenter = presenter;
            _formFactory = formFactory;

            InitializeComponent();

            _presenter.SetForm(this);
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
                        service.Description,
                        service.Category.Name
                    );
                }
            }
        }

        private void dgvServices_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServices.Rows.Count > 0)
            {
                var selectedService = _services.First(x => x.Id.ToString() == dgvServices[0, e.RowIndex].Value.ToString());

                lblCode.Text = selectedService.Code + @" - " + selectedService.Name;
                lblDescriptionValue.Text = selectedService.Description;
                lblServiceCategoryValue.Text = selectedService.Category.Name;
                //lblCreatedByValue.Text = selectedService.CreatedBy.ToString();
                lblCreatedOnValue.Text = selectedService.CreatedOn.ToString(@"d");

                foreach (var servicePricing in selectedService.ServicePrices)
                {
                    dgvServicePricings.Rows.Add(
                        servicePricing.VehicleSize.ToString(),
                        servicePricing.Price
                    );
                }
            }
        }

        private void lblServiceCategoryValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selectedService = _services.FirstOrDefault(x => x.Code == lblServiceCategoryValue.Text);

            if (selectedService != null)
            {
                var viewCategory = _formFactory.CreateForm<ViewDetail>();   

                viewCategory.ServiceCategory = selectedService.Category;

                viewCategory.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(@"No service selected", @"Error");
            }
        }
    }
}