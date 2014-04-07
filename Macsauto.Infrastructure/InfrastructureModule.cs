using Autofac;
using Autofac.Core;
using Autofac.Features.ResolveAnything;
using NHibernate;
using System.Linq;
using System.Reflection;

namespace Macsauto.Infrastructure
{
    using Macsauto.Infrastructure.NHibernate.Common;
    using Macsauto.Infrastructure.NHibernate.Contract;
    using Macsauto.Infrastructure.NHibernate;

    public class InfrastructureModule : Autofac.Module
    {
        private readonly string[] _connectionStrings;
        private readonly long _basePoint;

        public InfrastructureModule(long basePoint, string[] connectionStrings)
        {
            _connectionStrings = connectionStrings;
            _basePoint = basePoint;
        }

        protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
        {
            registration.Preparing += (sender, args) =>
                {
                    args.Parameters = args.Parameters.Union( new[] { new NamedParameter(@"basePoint", _basePoint) } );
                };
        }

        protected override void Load(ContainerBuilder builder)
        {
            InitializeSessionFactories();

            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterGeneric(typeof(TransactionalRepository<>)).As(typeof(ITransactionalRepository<>));
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();
            builder.Register(x => NHibernateSessionManager
                .SessionFactories
                .First(factory => !factory.WriteOnly).GetSession()
                ).As<ISession>();
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
        }

        private void InitializeSessionFactories()
        {
            bool writeOnly = false;

            foreach (var connectionString in _connectionStrings)
            {
                NHibernateSessionManager.AddSessionFactory(connectionString, writeOnly);

                writeOnly = true;
            }
        }
    }
}