namespace Macsauto.Infrastructure.NHibernateRepository
{
    using System.IO;

    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;

    using Macsauto.Infrastructure.Helper.Extension;
    using Macsauto.Infrastructure.NHibernateRepository.Conventions;
    using Macsauto.Infrastructure.NHibernateRepository.Employee;

    using NHibernate;
    using NHibernate.Cfg;
    using NHibernate.Tool.hbm2ddl;

    public class SessionManager
    {
        private const string SchemaFile = "macsauto.sql";

        private static ISessionFactory _sessionFactory;

        public static ISession GetSession()
        {
            if (_sessionFactory.IsNull())
            {
                InitializeSessionFactory();
            }

            return _sessionFactory.GetCurrentSession() ?? _sessionFactory.OpenSession();
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                    .Database(
                        MySQLConfiguration
                            .Standard
                            .ConnectionString(
                                string.Format("Server={0};Database={1};User Id={2};Password={3}",
                                    "127.0.0.1",
                                    "macsauto",
                                    "root",
                                    "root")
                            )
                    )
                    .Mappings(map =>
                    {
                        map.FluentMappings.Conventions.AddFromAssemblyOf<EnumConvention>();
                        map.FluentMappings.AddFromAssemblyOf<EmployeeMap>();
                    })
                    .ExposeConfiguration(BuildSchema)
                    .BuildSessionFactory());
        }

        private static void BuildSchema(Configuration conf)
        {
            if (File.Exists(SchemaFile))
            {
                File.Delete(SchemaFile);
            }

            new SchemaUpdate(conf)
                .Execute(true, true);
        }
    }
}