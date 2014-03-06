using Macsauto.Infrastructure.Helper.Extension;

namespace Macsauto.Presentation.WPF.Common.User.Login
{
    public class LoginCommand : CommandBase
    {
        private readonly LoginViewModel _vm;

        public LoginCommand(LoginViewModel vm)
        {
            _vm = vm;
        }

        public override void Execute(object parameter)
        {
            throw new System.NotImplementedException();
        }

        public override bool CanExecute(object parameter)
        {
            return !_vm.User.Username.IsNotNullOrEmpty()
                && !_vm.User.Password.IsNotNullOrEmpty();
        }
    }
}
