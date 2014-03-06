namespace Macsauto.Infrastructure.NHibernateRepository
{
    using System;
    using System.Collections.Generic;

    using Macsauto.Domain.Shared;
    using Macsauto.Infrastructure.NHibernateRepository.Contract;

    using NHibernate;
    using NHibernate.Criterion;

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

        public void Delete(TEntity entity)
        {
            _session.Delete(entity);
        }

        public void DeleteAll()
        {
            _session.Delete(string.Format("from {0}", typeof(TEntity)));
        }

        public void DeleteAll(DetachedCriteria criteria)
        {
            foreach (var entity in criteria.GetExecutableCriteria(_session).List())
            {
                _session.Delete(entity);
            }
        }

        public TEntity Save(TEntity entity)
        {
            _session.Save(entity);

            return entity;
        }

        public TEntity SaveOrUpdate(TEntity entity)
        {
            _session.SaveOrUpdate(entity);

            return entity;
        }

        public void Update(TEntity entity)
        {
            _session.Update(entity);
        }

        public long Count()
        {
            return Count(null);
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
            throw new NotImplementedException();
        }

        public IList<TEntity> FindAll(DetachedCriteria criteria, params Order[] orders)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}