namespace Macsauto.Presentation
{
    using Autofac;

    using Macsauto.Infrastructure;
    using Macsauto.Infrastructure.Helper.Extension;

    public static class BootStrap
    {
        private static ContainerBuilder _builder;
        private static bool _strapped = false;

        public static IContainer Strap()
        {
            if (_builder.IsNull())
            {
                _builder = new ContainerBuilder();

                _builder.RegisterModule(new InfrastructureModule());

                _strapped = true;
            }

            return _builder.Build();
        }

        public static bool IsStrapped()
        {
            return _strapped;
        }
    }
}
