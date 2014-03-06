namespace Macsauto.Presentation.WinForm
{
    using System;

    using Autofac;

    public class SplashEventArgs : EventArgs
    {
        private readonly IContainer _container;

        public SplashEventArgs(IContainer container)
        {
            _container = container;
        }

        public IContainer Container
        {
            get { return _container; }
        }
    }
}