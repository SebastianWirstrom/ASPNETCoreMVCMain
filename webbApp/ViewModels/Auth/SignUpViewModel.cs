using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using webbApp.Helpers;

namespace webbApp.ViewModels.Auth;

public class SignUpViewModel
{
    [DataType(DataType.Text)]
    [Display(Name = "First Name", Prompt = "Enter your first name")]
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = null!;

    [DataType(DataType.Text)]
    [Display(Name = "Last Name", Prompt = "Enter your last name")]
    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    [Display(Name = "E-mail", Prompt = "Enter your E-mail")]
    [Required(ErrorMessage = "E-mail is required")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password", Prompt = "Confirm your password")]
    [Required(ErrorMessage = "Confirming password is required")]
    [Compare(nameof(Password), ErrorMessage = "Password doesn't match")]
    public string ConfirmPassword { get; set; } = null!;



    [RequiredCheckbox(ErrorMessage = "Terms and Conditions must be accepted")]
    public bool TermsAndConditions { get; set; }
}
