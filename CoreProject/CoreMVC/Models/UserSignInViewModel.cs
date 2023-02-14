using System.ComponentModel.DataAnnotations;

namespace CoreMVC.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adı giriniz.")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string password { get; set; }
    }
}
