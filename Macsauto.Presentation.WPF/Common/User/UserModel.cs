namespace Macsauto.Presentation.WPF.Common.User
{
    using System.ComponentModel.DataAnnotations;

    public class UserModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
