namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Payment
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class CardIssuerRepository : NHibernateRepository<CardIssuer>, ICardIssuerRepository
    {
        public CardIssuerRepository(IRepository<CardIssuer> repository, ITransactionalRepository<CardIssuer> transactionalRepository) : base(repository, transactionalRepository)
        {
        }
    }
}