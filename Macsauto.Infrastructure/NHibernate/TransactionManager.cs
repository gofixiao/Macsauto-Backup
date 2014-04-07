using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using NHibernate;
using System;
using System.Collections.Generic;

namespace Macsauto.Infrastructure.NHibernate
{
    public class TransactionManager : IDisposable
    {
        private readonly ICollection<NHibernateSessionFactory> _sessionFactories;
        private readonly ICollection<ISession> _sessions;
        private ISession _session;
        private ITransaction _transaction;

        public TransactionManager()
        {
            _sessionFactories = NHibernateSessionManager.SessionFactories;
            _sessions = new Collection<ISession>();
        }

        public ISession BeginTransaction()
        {
            foreach (var sessionFactory in _sessionFactories)
            {
                _sessions.Add(sessionFactory.GetSession());

                if (!sessionFactory.WriteOnly)
                {
                    _session = _sessions.Last();
                    _transaction = _session.BeginTransaction();
                }
            }

            _transaction.Begin(IsolationLevel.ReadCommitted);

            return _session;
        }

        public void Complete()
        {
            
            try
            {
                _transaction.Commit();
            }
            catch (Exception)
            {
                _transaction.Rollback();

                throw;
            }
        }

        public void Dispose()
        {
            foreach (var session in _sessions)
            {
                session.Disconnect();
                session.Dispose();
            }
        }
    }
}