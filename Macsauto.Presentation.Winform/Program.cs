using Macsauto.Presentation.WinForm.PointOfSalesModule.Dashboard;

namespace Macsauto.Presentation.WinForm
{
    using System;
    using System.Windows.Forms;

    using Autofac;

    using Macsauto.Presentation.WinForm.ConfigurationModule.Startup;
    
    static class Program
    {
        private static IContainer _container;
        private static SplashScreen _splashScreen;
        private static MainWindow _mainWindow;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CheckStartupConfiguration();

            _mainWindow = new MainWindow();

            _splashScreen = new SplashScreen(false);
            
            _splashScreen.DoneStartup += splashScreen_doneStartUp;

            _splashScreen.ShowDialog();

            _mainWindow.AutofacContainer = _container;

            Application.Run(_mainWindow);
            //Application.Run(_container.Resolve<PointOfSalesModule.Dashboard.Dashboard>());
        }

        private static void splashScreen_doneStartUp(object sender, SplashEventArgs e)
        {
            _container = e.Container;
        }

        [System.Runtime.InteropServices.DllImport(@"user32.dll")]
        private static extern bool SetProcessDPIAware();

        private static void CheckStartupConfiguration()
        {
            if (Properties.Settings.Default.MainConnectionUser == string.Empty)
            {
                var config = new StartupConfiguration(new StartupConfigurationPresenter());

                config.ShowDialog();
            }
        }
    }
}