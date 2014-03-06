using NHibernate;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.Common
{
    using System;
    using System.Collections.Generic;

    using Macsauto.Domain.Shared;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        #region Field

        private readonly ISession _session;

        #endregion

        #region Constructor

        public Repository(ISession session)
        {
            _session = session;
        }

        #endregion

        #region Methods (IRepository)

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public TEntity Get(object id)
        {
            return (TEntity) _session.Get(typeof (TEntity), id);
        }

        public TEntity Load(object id)
        {
            return (TEntity) _session.Load(typeof (TEntity), id);
        }

        public TEntity FindFirst(DetachedCriteria criteria)
        {
            var executableCriteria = criteria.GetExecutableCriteria(_session);

            return (TEntity) executableCriteria.UniqueResult();
        }

        public long Count()
        {
            return Count(DetachedCriteria.For<TEntity>());
        }

        public long Count(DetachedCriteria criteria)
        {
            var executableCriteria = criteria.GetExecutableCriteria(_session);

            var count = executableCriteria.SetProjection(Projections.RowCount()).UniqueResult();

            return Convert.ToInt64(count);
        }

        public bool Exists(object id)
        {
            var criteria = DetachedCriteria.For<TEntity>();

            criteria.Add(Restrictions.Eq(Projections.Id(), id));
            criteria.SetProjection(Projections.RowCount());

            return Count(criteria) > 0;
        }

        public bool Exists(DetachedCriteria criteria)
        {
            return Count(criteria) > 0;
        }

        public IList<TEntity> GetAll()
        {
            return _session.QueryOver<TEntity>().List();
        }

        public IList<TEntity> FindAll(DetachedCriteria criteria, params Order[] orders)
        {
            var executableCriteria = criteria.GetExecutableCriteria(_session);

            Array.ForEach(orders, order => executableCriteria.AddOrder(order));

            return executableCriteria.List<TEntity>();
        }

        #endregion
    }
}