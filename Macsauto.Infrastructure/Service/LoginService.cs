using Macsauto.Domain;

namespace Macsauto.Infrastructure.Service
{
    using System;
    using Macsauto.Infrastructure.Helper.Extension;
    using Macsauto.Infrastructure.Helper.Client;
    using Macsauto.Infrastructure.NHibernate;
    using Macsauto.Infrastructure.NHibernate.Common;

    public class LoginService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITerminalRepository _terminalRepository;
        private readonly ClientAdapter _clientAdapter;

        public LoginService(IUserRepository userRepository, ITerminalRepository terminalRepository, ClientAdapter clientAdapter)
        {
            _userRepository = userRepository;
            _terminalRepository = terminalRepository;
            _clientAdapter = clientAdapter;
        }

        public User Login(string username, string password)
        {
            var session = NHibernateSessionManager.GetLocalSession();
            var macAddress = _clientAdapter.GetCurrentClientMacAddress();
            var user = _userRepository.LoginActiveUser(username, password);
            var terminal = _terminalRepository.FindByMac(macAddress);

            if (user.IsNull())
            {
                throw new ApplicationException(@"User not found");
            }

            if (terminal == null)
            {
                session.DoTransactional(sess => 
                    terminal = _terminalRepository.Insert(
                        new Terminal(
                            string.Format(@"T-{0}/{1:00}", user.Employee.Branch.Code ,_terminalRepository.Count() + 1),
                            macAddress, 
                            user.Employee.Branch
                        )
                    )
                );
            }

            LoggedInUser = user;
            LoggedInUserBranch = user.Employee.Branch;
            LoggedInTerminal = terminal;

            return user;
        }

        public void Logout(User loggedInUser)
        {
            LoggedInUser = null;
            LoggedInUserBranch = null;
            LoggedInTerminal = null;
        }

        public static User LoggedInUser { get; private set; }

        public static Branch LoggedInUserBranch { get; private set; }

        public static Terminal LoggedInTerminal { get; private set; }
    }
}
