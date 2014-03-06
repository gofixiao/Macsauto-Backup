namespace Macsauto.Infrastructure.Crosscutting
{
    using Autofac;
    using Autofac.Features.ResolveAnything;
    using Macsauto.Infrastructure.Crosscutting.AuthorizationRequired;

    public class InfrastructureCrosscuttingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new AuthorizationRequiredInterceptor());
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
        }
    }
}
