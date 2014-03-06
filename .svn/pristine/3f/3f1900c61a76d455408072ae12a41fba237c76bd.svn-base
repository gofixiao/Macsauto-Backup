namespace Macsauto.Presentation.WinForm.ConfigurationModule.Branch
{
    using Macsauto.Domain.UserManagementModule;

    public class ViewAllPresenter
    {
        private readonly IBranchRepository _branchRepo;
        private ViewAll _form;

        public ViewAllPresenter(IBranchRepository branchRepo)
        {
            _branchRepo = branchRepo;
        }

        public void SetForm(ViewAll form)
        {
            _form = form;

            _form.Branches = _branchRepo.GetAll();
        }
    }
}