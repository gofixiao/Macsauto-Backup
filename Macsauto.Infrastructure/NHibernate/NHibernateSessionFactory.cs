using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;
using NHibernate.Context;
using NHibernate.Event;
using NHibernate.Tool.hbm2ddl;

namespace Macsauto.Infrastructure.NHibernate
{
    using Macsauto.Infrastructure.NHibernate.Common;
    using Macsauto.Infrastructure.NHibernate.Conventions;
    using Macsauto.Infrastructure.NHibernate.Interceptors;
    using Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Employee;

    public class NHibernateSessionFactory
    {
        private ISessionFactory _sessionFactory;
        private readonly string _connection;
        private readonly bool _writeOnly;
        private bool _isInitialized;

        public NHibernateSessionFactory(string connection, bool writeOnly = true)
        {
            _connection = connection;
            _writeOnly = writeOnly;
            _isInitialized = false;
        }

        public ISessionFactory SessionFactory
        {
            get { return _sessionFactory; }
        }

        public string Connection
        {
            get { return _connection; }
        }

        public bool WriteOnly
        {
            get { return _writeOnly; }
        }

        public bool IsInitialized
        {
            get { return _isInitialized; }
        }

        public void InitializeFactory()
        {
            if (!_isInitialized)
            {
                FluentConfiguration conf = Fluently.Configure()
                    .Database(MySQLConfiguration.Standard.ConnectionString(_connection))
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
                        x.EventListeners.PreInsertEventListeners = new IPreInsertEventListener[] {new EntityService()};
                    });

                if (!_writeOnly)
                {
                    conf.ExposeConfiguration(config => new SchemaUpdate(conf.BuildConfiguration()).Execute(true, true));
                }

                _sessionFactory = conf.BuildSessionFactory();

                _isInitialized = true;
            }
        }

        public ISession GetSession()
        {
            if (!_isInitialized)
            {
                InitializeFactory();
            }

            return _sessionFactory.GetCurrentSession() ?? _sessionFactory.OpenSession();
        }
    }
}