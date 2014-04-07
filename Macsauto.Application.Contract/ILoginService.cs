namespace Macsauto.Application.Contract
{
    /// <summary>
    /// Provides the gateway for application's login and logout feature
    /// </summary>
    public interface ILoginService
    {
        /// <summary>
        /// Main login gateway
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Unhashed password</param>
        void Login(string username, string password);

        /// <summary>
        /// Main logout gateway
        /// </summary>
        void Logout();

        /// <summary>
        /// Check if any user is logged in
        /// </summary>
        /// <returns></returns>
        bool IsLoggedIn();
    }
}