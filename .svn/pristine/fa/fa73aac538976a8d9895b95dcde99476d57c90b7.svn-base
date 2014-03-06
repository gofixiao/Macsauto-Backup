using Macsauto.Infrastructure.Crosscutting;

namespace Macsauto.Presentation.WinForm
{
    using System;
    using System.ComponentModel;

    using Autofac;

    using Macsauto.Infrastructure;
    using Macsauto.Infrastructure.Helper.Extension;

    public static class BootStrap
    {
        private static ContainerBuilder _builder;
        private static Autofac.IContainer _container;
        private static bool _strapped;

        public static Autofac.IContainer Strap()
        {
            OnProgressChanged(0, @"Start bootstraping...");

            if (_builder.IsNull())
            {
                _builder = new ContainerBuilder();

                _builder.RegisterModule(new InfrastructureModule(25000));
                _builder.RegisterModule(new InfrastructureCrosscuttingModule());
                _builder.RegisterModule(new PresentationModule());

                _container = _container ?? _builder.Build();

                _builder = new ContainerBuilder();

                _builder.RegisterInstance(_container).As<Autofac.IContainer>();
                _builder.Update(_container);

                _strapped = true;
            }

            OnProgressChanged(20, @"Done registering modules..");

            return _container;
        }

        public static bool IsStrapped()
        {
            return _strapped;
        }

        public static event Action<object, ProgressChangedEventArgs> ProgressChanged;

        private static void OnProgressChanged(int progress, string message)
        {
            var handler = ProgressChanged;

            if (handler != null)
            {
                ProgressChanged(message, new ProgressChangedEventArgs(progress, null));
            }
        }
    }
}