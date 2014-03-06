using System;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories
{
    using System.Collections.Generic;
    using Macsauto.Domain.Shared;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class NHibernateRepository<T> : Domain.Contract.IRepository<T> where T : Entity
    {
        private readonly IRepository<T> _repository;
        private readonly ITransactionalRepository<T> _transactionalRepository; 

        public NHibernateRepository(IRepository<T> repository, ITransactionalRepository<T> transactionalRepository)
        {
            _repository = repository;
            _transactionalRepository = transactionalRepository;
        }

        public long Count()
        {
            return _repository.Count();
        }

        public long GetLastDailyIndex()
        {
            var criteria = DetachedCriteria.For<T>()
                                           .Add(
                                                Restrictions.Conjunction()
                                                .Add(Restrictions.Gt(@"CreatedOn", DateTime.Today))
                                                .Add(Restrictions.Lt(@"CreatedOn", DateTime.Today.AddDays(1).AddTicks(-1)))
                                            );

            return _repository.Count(criteria);
        }

        public T FindById(object id)
        {
            return _repository.Get(id);
        }

        public T Insert(T t)
        {
            return _transactionalRepository.Save(t);
        }

        public void Update(T t)
        {
            _transactionalRepository.Update(t);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}