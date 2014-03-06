namespace Macsauto.Presentation.WinForm.ConfigurationModule.Startup
{
    public class StartupConfigurationPresenter
    {
        private readonly Properties.Settings _settings;
        private StartupConfiguration _frm;

        public StartupConfigurationPresenter()
        {
            _settings = Properties.Settings.Default;
        }

        public void SetForm(StartupConfiguration frm)
        {
            _frm = frm;

            _frm.ConnectionHost = _settings.MainConnectionHost;
            _frm.ConnectionDatabase = _settings.MainConnectionDatabase;
            _frm.ConnectionUser = _settings.MainConnectionUser;
            _frm.ConnectionPassword = _settings.MainConnectionPassword;
        }
    }
}