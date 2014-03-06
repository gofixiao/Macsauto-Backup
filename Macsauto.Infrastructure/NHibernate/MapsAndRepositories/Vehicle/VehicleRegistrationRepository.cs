using Macsauto.Domain.SalesModule;
using Macsauto.Infrastructure.NHibernate.Contract;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Vehicle
{
    public class VehicleRegistrationRepository : NHibernateRepository<VehicleRegistration>, IVehicleRegistrationRepository
    {
        public VehicleRegistrationRepository(IRepository<VehicleRegistration> repository, ITransactionalRepository<VehicleRegistration> transactionalRepository) : base(repository, transactionalRepository)
        {
        }
    }
}
