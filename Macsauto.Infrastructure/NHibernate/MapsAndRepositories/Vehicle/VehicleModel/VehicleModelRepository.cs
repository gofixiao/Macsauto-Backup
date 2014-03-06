using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Vehicle.VehicleModel
{
    using System.Collections.Generic;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;    

    public class VehicleModelRepository : NHibernateRepository<VehicleModel>, IVehicleModelRepository
    {
        private readonly IRepository<VehicleModel> _repo;
        private readonly ITransactionalRepository<VehicleModel> _transactionalRepo;

        public VehicleModelRepository(IRepository<VehicleModel> repo, ITransactionalRepository<VehicleModel> transactionalRepo) : base(repo, transactionalRepo)
        {
            _repo = repo;
            _transactionalRepo = transactionalRepo;
        }

        public IList<VehicleModel> GetAllInBrand(VehicleBrand brand)
        {
            var criteria = DetachedCriteria.For<VehicleModel>()
                                           .Add(Restrictions.Eq(@"Brand", brand));

            return _repo.FindAll(criteria);
        }
    }
}