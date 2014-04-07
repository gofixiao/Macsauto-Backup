using Macsauto.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.Common
{
    using Macsauto.Domain.Contract;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class TransactionalRepository <TEntity> : ITransactionalRepository<TEntity>
        where TEntity : Entity
    {
        private readonly ISession _session;

        public TransactionalRepository(ISession session)
        {
            _session = session;
        }

        
    }
}