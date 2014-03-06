namespace Macsauto.Presentation.WinForm
{
    using Autofac;
    using Autofac.Features.ResolveAnything;
    using Macsauto.Domain.SalesModule;

    public class PresentationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PaymentService>().As<IPaymentService>();
            builder.RegisterType<FormFactory>().As<IFormFactory>();
            builder.RegisterType<MainWindow>().AsSelf().SingleInstance();
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
        }
    }
}
