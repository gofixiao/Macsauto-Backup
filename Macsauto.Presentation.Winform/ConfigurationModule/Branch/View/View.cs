namespace Macsauto.Presentation.WinForm.ConfigurationModule.Branch
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Macsauto.Domain.UserManagementModule;

    public partial class View : Form
    {
        private readonly ViewPresenter _presenter;
        private IList<Employee> _employees;
        private Branch _branch;

        public View(ViewPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public Branch Branch
        {
            get { return _branch; }
            set
            {
                _branch = value;

                lblTitle.Text = _branch.Code + @" : " + _branch.Name;
                txtAddressLine.Text = _branch.Address.AddressLine;
                cboCity.Text = _branch.Address.City.Name;
                cboProvince.Text = _branch.Address.City.Province.Name;
                txtZipcode.Text = _branch.Address.Zipcode;

                _presenter.GetEmployees();
            }
        }

        public IList<Employee> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;

                dgvEmployees.Rows.Clear();

                foreach (var employee in _employees)
                {
                    dgvEmployees.Rows.Add(
                        employee.Id,
                        employee.Code,
                        employee.Name.Fullname,
                        employee.Gender,
                        employee.Position.ToString(),
                        employee.Email,
                        employee.CellPhone
                    );
                }
            }
        }
    }
}