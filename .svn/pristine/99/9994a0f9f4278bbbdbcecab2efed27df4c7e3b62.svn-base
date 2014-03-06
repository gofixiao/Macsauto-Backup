using FluentNHibernate.Conventions.Inspections;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Event;
using NHibernate.Tool.hbm2ddl;

namespace Macsauto.Infrastructure.NHibernate
{
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using FluentNHibernate.Conventions.Helpers;
    using Macsauto.Infrastructure.Helper.Extension;
    using Macsauto.Infrastructure.NHibernate.Common;
    using Macsauto.Infrastructure.NHibernate.Conventions;
    using Macsauto.Infrastructure.NHibernate.Interceptors;
    using Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Employee;

    public static class NHibernateSessionManager
    {
        private static ISessionFactory _localSessionFactory;
        private static ISessionFactory _branchSessionFactory;

        private static string _localConnString = "Server=127.0.0.1;Database=macsauto2;User Id=root;Password=root";
        private static string _branchConnString;

        public static void SetConnectionStrings(string branch, string local = null)
        {
            _branchConnString = branch;
        }

        public static ISession GetLocalSession()
        {
            //_localSessionFactory = _localSessionFactory.Initialize(_localConnString, true);
            _localSessionFactory = _localSessionFactory.Initialize(_localConnString);

            return _localSessionFactory.GetCurrentSession() ?? _localSessionFactory.OpenSession();
        }

        public static ISession GetBranchSession()
        {
            if (_branchSessionFactory == null)
            {
                return null;
            }

            return _branchSessionFactory.GetCurrentSession() ?? _branchSessionFactory.OpenSession();
        }

        public static void InitializeBranchSession()
        {
            _branchSessionFactory = _branchSessionFactory.Initialize(_branchConnString);
        }

        private static ISessionFactory Initialize(this ISessionFactory sessionFactory, string connectionString,
                                                  bool buildSchema = false)
        {
            if (sessionFactory.IsNull())
            {
                var conf = GetFluentConfiguration(connectionString);

                if (buildSchema)
                {
                    conf = conf.ExposeConfiguration(BuildSchema);
                }

                sessionFactory = conf.BuildSessionFactory();
            }

            return sessionFactory;
        }

        private static FluentConfiguration GetFluentConfiguration(string connectionString)
        {
            return Fluently.Configure()
                           .Database(
                               MySQLConfiguration
                                   .Standard
                                   .ConnectionString(connectionString)
                            )
                           .CurrentSessionContext<ThreadLocalSessionContext>()
                           .Mappings(map =>
                               {
                                   map.FluentMappings.Conventions.Add(
                                       new EnumConvention(),
                                       new CascadeAllConvention(),
                                       new ColumnNameConvention(),
                                       new TableNameConvention(),
                                       LazyLoad.Never()
                                    );
                                   map.FluentMappings.AddFromAssemblyOf<EmployeeMap>();
                               })
                           .ExposeConfiguration(x =>
                           {
                               x.SetInterceptor(new SqlStatementInterceptor());
                               x.EventListeners.PreInsertEventListeners = new IPreInsertEventListener[]{new EntityService()};
                           });
        }

        private static void BuildSchema(Configuration conf)
        {
            new SchemaUpdate(conf)
                .Execute(true, true);
        }

        public static bool CompareSession(this ISession first, ISession second)
        {
            return first.GetSessionImplementation().SessionId.Equals(second.GetSessionImplementation().SessionId);
        }
    }
}