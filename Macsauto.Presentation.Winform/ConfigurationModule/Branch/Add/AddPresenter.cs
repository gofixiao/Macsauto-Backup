namespace Macsauto.Presentation.WinForm.ConfigurationModule.Branch
{
    using Macsauto.Domain.Shared;
    using Macsauto.Domain.UserManagementModule;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class AddPresenter
    {
        private readonly IBranchRepository _branchRepo;
        private readonly IProvinceRepository _provinceRepo;
        private readonly ICityRepository _cityRepo;
        private Add _form;

        public AddPresenter(IBranchRepository branchRepo, IProvinceRepository provinceRepo, ICityRepository cityRepo)
        {
            _branchRepo = branchRepo;
            _provinceRepo = provinceRepo;
            _cityRepo = cityRepo;
        }

        public void SetForm(Add form)
        {
            _form = form;

            _form.BranchCode = string.Format("B{0:00}", _branchRepo.GetLastIndex() + 1);
            _form.Provinces = _provinceRepo.GetAll();
        }

        public void GetCities(Province province)
        {
            _form.Cities = _cityRepo.GetWhereProvince(province);
        }

        public Branch Save()
        {
            Branch branch = null;
            var session = NHibernateSessionManager.GetLocalSession();

            session.DoTransactional(sess => 
                branch = _branchRepo.Insert(
                    new Branch(
                        _form.BranchCode,
                        _form.BranchName,
                        new Address(
                            _form.City,
                            _form.Zipcode,
                            _form.AddressLine
                        )
                    )
                )
            );

            return branch;
        }
    }
}