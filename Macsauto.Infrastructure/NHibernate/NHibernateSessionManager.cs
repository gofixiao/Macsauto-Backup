using System;
using System.Linq;
using NHibernate;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Macsauto.Infrastructure.NHibernate
{
    public static class NHibernateSessionManager
    {
        private static ICollection<NHibernateSessionFactory> _sessionFactories;

        public static void AddSessionFactory(string connection, bool writeOnly = true)
        {
            if (_sessionFactories == null)
            {
                _sessionFactories = new Collection<NHibernateSessionFactory>();
            }

            if (writeOnly && _sessionFactories.Any(factory => !factory.WriteOnly))
            {
                throw new Exception(@"Only one session factory is allowed to be read");
            }

            _sessionFactories.Add(new NHibernateSessionFactory(connection, writeOnly));
        }

        public static ICollection<NHibernateSessionFactory> SessionFactories
        {
            get { return _sessionFactories; }
        }

        public static void InitializeFactories()
        {
            foreach (var sessionFactory in _sessionFactories)
            {
                sessionFactory.InitializeFactory();
            }
        }

        public static bool CompareSession(this ISession first, ISession second)
        {
            return first.GetSessionImplementation().SessionId.Equals(second.GetSessionImplementation().SessionId);
        }
    }
}