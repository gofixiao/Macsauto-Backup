namespace Macsauto.Infrastructure.NHibernateRepository
{
    using System.Reflection;

    using Autofac;
    using Autofac.Features.ResolveAnything;
    
    using Macsauto.Infrastructure.NHibernateRepository.Contract;

    public class NHibernateRepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());

            builder.RegisterGeneric(typeof (Repository<>)).As(typeof (IRepository<>));
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();
        }
    }
}