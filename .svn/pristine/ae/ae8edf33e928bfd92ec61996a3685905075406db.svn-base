using System.Windows.Input;

namespace Macsauto.Presentation.WPF.Common.User.Login
{
    public class LoginViewModel : ViewModelBase
    {
        public ICommand DoLogin { get; set; }
        public UserModel User { get; set; }

        public LoginViewModel()
        {
            DoLogin = new LoginCommand(this);
        }
    }
}