using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using Autofac;
using Macsauto.Presentation.WPF.Common.User.Login;

namespace Macsauto.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var container = BootStrap.Strap();

            container.Resolve<Login>();
        }
    }
}
