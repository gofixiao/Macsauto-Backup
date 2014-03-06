using System.Linq;
using System.Reflection;
using NHibernate;

namespace Macsauto.Infrastructure
{
    using Autofac;
    using Autofac.Core;
    using Autofac.Features.ResolveAnything;
    using Macsauto.Infrastructure.NHibernate.Common;
    using Macsauto.Infrastructure.NHibernate.Contract;
    using Macsauto.Infrastructure.NHibernate;

    public class InfrastructureModule : Module
    {
        private readonly long _basePoint;

        public InfrastructureModule(long basePoint)
        {
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
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterGeneric(typeof(TransactionalRepository<>)).As(typeof(ITransactionalRepository<>));
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();
            builder.Register(x => NHibernateSessionManager.GetLocalSession()).As<ISession>();
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
        }
    }
}