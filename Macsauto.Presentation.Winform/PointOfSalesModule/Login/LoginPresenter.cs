using Macsauto.Domain;

namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Login
{
    using System;
    using Macsauto.Infrastructure.Helper.Extension;
    using Macsauto.Infrastructure.Service;

    public class LoginPresenter
    {
        private readonly LoginService _loginService;
        private LoginFrm _frm;

        public LoginPresenter(LoginService loginService)
        {
            _loginService = loginService;
        }

        public void SetForm(LoginFrm form)
        {
            _frm = form;
        }

        public User DoLogin()
        {
            var user = _loginService.Login(_frm.Username, _frm.Password);

            //var user = _loginService.Login("SAMUEL", "123");
            
            if (user.IsNull())
            {
                throw new ApplicationException("Wrong username / password");
            }

            return user;
        }
    }
}