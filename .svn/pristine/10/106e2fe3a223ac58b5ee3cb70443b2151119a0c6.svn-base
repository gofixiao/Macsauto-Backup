namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Merchandise
{
    using Macsauto.Infrastructure.NHibernate.Contract;
    using Macsauto.Domain.SalesModule;

    public class MerchandiseRepository : NHibernateRepository<Merchandise>, IMerchandiseRepository
    {
        public MerchandiseRepository(IRepository<Merchandise> repository, ITransactionalRepository<Merchandise> transactionalRepository) : base(repository, transactionalRepository)
        {
        }
    }
}