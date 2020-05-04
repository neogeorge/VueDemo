using System.ComponentModel.DataAnnotations;

namespace VueDemoWeb.Models.ViewModel
{
    public class AccountViewModels
    {
        public string AccountId { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public string Password { get; set; }
    }

    public class LoginViewModels
    {
        [Required]
        [Display(Name = "帳號")]
        public string AccountId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [Display(Name = "記住我")]
        public bool RememberMe { get; set; }
    }
}