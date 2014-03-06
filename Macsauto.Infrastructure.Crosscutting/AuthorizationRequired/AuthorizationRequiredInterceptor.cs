using Castle.DynamicProxy;
using Macsauto.Infrastructure.Service;
using Macsauto.Infrastructure.Helper.Extension;

namespace Macsauto.Infrastructure.Crosscutting.AuthorizationRequired
{
    public class AuthorizationRequiredInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var method = invocation.Method;

            if (method.IsDecoratedBy(typeof(AuthorizationRequiredAttribute)))
            {
                var loggedInUser = LoginService.LoggedInUser;

                var authorizationForm = new AuthorizationForm();

                authorizationForm.ShowDialog();
            }

            invocation.Proceed();
        }
    }
}