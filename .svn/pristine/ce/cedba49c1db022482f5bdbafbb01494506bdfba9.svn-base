namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Login
{
    using System;
    using System.Windows.Forms;
    using Macsauto.Domain.UserManagementModule;
    using Macsauto.Infrastructure.Helper.Extension;

    public partial class LoginFrm : Form
    {
        private readonly LoginPresenter _presenter;
        private static User _loggedInUser;

        public delegate void LoginSuccessHandler();
        public event EventHandler LoginSuccess;

        public LoginFrm(LoginPresenter presenter)
        {
            _presenter = presenter;
            
            InitializeComponent();
            
            _presenter.SetForm(this);
        }

        public static User LoggedInUser
        {
            get { return _loggedInUser; }
            private set { _loggedInUser = value; }
        }

        public string Username
        {
            get { return txtUsername.Text; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show(@"Please fill username and password");
            }
            else
            {
                try
                {
                    LoggedInUser = _presenter.DoLogin();

                    MessageBox.Show(@"Login success", @"Success");

                    Hide();

                    LoginSuccess(this, new EventArgs());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;

                    txtUsername.Focus();
                }   
            }
        }

        private void LoginFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LoggedInUser.IsNull() && MessageBox.Show(@"You are not logged in. Quit application?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}