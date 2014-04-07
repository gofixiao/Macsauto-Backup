using System;

namespace Macsauto.Application.Login
{
    using Macsauto.Application.Contract;
    using Macsauto.Domain.UserManagementModule;
    using Macsauto.Infrastructure.Helper.Hasher.Contract;

    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepo;
        private readonly IHasher _hasher;

        public LoginService(IUserRepository userRepo, IHasher hasher)
        {
            _userRepo = userRepo;
            _hasher = hasher;
        }

        public void Login(string username, string password)
        {
            if (!IsLoggedIn())
            {
                var user = _userRepo.LoginActiveUser(username, _hasher.Hash(password));

                if (user == null)
                {
                    throw new Exception(@"Login failed");
                }

                LoginInfo.SetLoginInfo(user);
            }
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                LoginInfo.RemoveLoginInfo();
            }
        }

        public bool IsLoggedIn()
        {
            return LoginInfo.LoggedInUser != null;
        }
    }
}