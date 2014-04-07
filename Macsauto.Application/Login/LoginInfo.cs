using System;

namespace Macsauto.Application.Login
{
    using Macsauto.Domain.UserManagementModule;

    /// <summary>
    /// Static class that holds the logged in user information, as well as another login related information
    /// </summary>
    public static class LoginInfo
    {
        /// <summary>
        /// Sets the global login information
        /// </summary>
        /// <param name="user">The logged in user</param>
        public static void SetLoginInfo(User user)
        {
            LoggedInUser = user;
            LoginTime = DateTime.Now;
        }

        /// <summary>
        /// Removes the global login information
        /// </summary>
        public static void RemoveLoginInfo()
        {
            LoggedInUser = null;
            LoginTime = null;
        }

        /// <summary>
        /// The logged in user
        /// </summary>
        public static User LoggedInUser { get; private set; }

        /// <summary>
        /// Latest login time
        /// </summary>
        public static DateTime? LoginTime { get; private set; }

        /// <summary>
        /// How many minutes since the logged in user logged
        /// </summary>
        public static double LoginDuration
        {
            get { return (DateTime.Now - LoginTime).Value.TotalMinutes; }
        }
    }
}