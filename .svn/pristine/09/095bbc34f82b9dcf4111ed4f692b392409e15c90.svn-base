using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.Contract
{
    using Macsauto.Domain.Shared;

    public interface ITransactionalRepository <TEntity>
        where TEntity : Entity
    {
        void Delete(TEntity entity);
        void DeleteAll();
        void DeleteAll(DetachedCriteria criteria);
        TEntity Save(TEntity entity);
        TEntity SaveOrUpdate(TEntity entity);
        void Update(TEntity entity); 
    }
}