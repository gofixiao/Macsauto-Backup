namespace Macsauto.Presentation.WinForm.ConfigurationModule.Startup
{
    using System.Windows.Forms;

    public partial class StartupConfiguration : Form
    {
        private readonly StartupConfigurationPresenter _presenter;
        
        public StartupConfiguration(StartupConfigurationPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public string ConnectionHost
        {
            get { return txtHost.Text; }
            set { txtHost.Text = value; }
        }

        public string ConnectionDatabase
        {
            get { return txtDatabase.Text; }
            set { txtDatabase.Text = value; }
        }

        public string ConnectionUser
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }

        public string ConnectionPassword
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        private void StartupConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((txtUsername.Text == string.Empty || txtPassword.Text == string.Empty) 
                && MessageBox.Show(@"Configuration is incomplete. Continue anyway?", @"Warning", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            //_presenter.Save();
        }
    }
}