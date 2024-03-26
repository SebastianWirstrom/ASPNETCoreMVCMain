using System.ComponentModel.DataAnnotations;
using webbApp.Helpers;

namespace webbApp.ViewModels.Auth;

public class SignInViewModel
{
    [DataType(DataType.EmailAddress)]
    [Display(Name = "E-mail", Prompt = "Enter your E-mail")]
    [Required(ErrorMessage = "E-mail is required")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; } = null!;



    public bool RememberMe { get; set; }
}
