using Macsauto.Domain;

namespace Macsauto.Presentation.WinForm.ConfigurationModule.Branch
{
    public class ViewPresenter
    {
        private readonly IBranchRepository _branchRepo;
        private readonly IEmployeeRepository _employeeRepo;
        private View _form;

        public ViewPresenter(IBranchRepository branchRepo, IEmployeeRepository employeeRepo)
        {
            _branchRepo = branchRepo;
            _employeeRepo = employeeRepo;
        }

        public void SetForm(View form)
        {
            _form = form;
        }

        public void GetEmployees()
        {
            _form.Employees = _employeeRepo.GetAllInBranch(_form.Branch);
        }
    }
}