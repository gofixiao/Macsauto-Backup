using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.Contract
{
    using System;
    using System.Collections.Generic;
    
    using Macsauto.Domain.Shared;

    public interface IRepository<TEntity> : IDisposable
        where TEntity : Entity
    {
        TEntity Get(object id);
        TEntity Load(object id);
        TEntity FindFirst(DetachedCriteria criteria);
        long Count();
        long Count(DetachedCriteria criteria);
        bool Exists(object id);
        bool Exists(DetachedCriteria criteria);
        IList<TEntity> GetAll();
        IList<TEntity> FindAll(DetachedCriteria criteria, params Order[] orders);
    }
}