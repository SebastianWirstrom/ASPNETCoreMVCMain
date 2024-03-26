using System.ComponentModel.DataAnnotations;

namespace webbApp.ViewModels.Account
{
    public class AccountDetailsBasicInfoViewModel
    {
        public string UserId { get; set; } = null!;

        [DataType(DataType.Text)]
        [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } = null!;

        [DataType(DataType.Text)]
        [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } = null!;

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address", Prompt = "Enter your Email address", Order = 2)]
        [Required(ErrorMessage = "E-mail address is required")]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address. Must be in format name@domain.com")]
        public string Email { get; set; } = null!;

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number", Prompt = "Enter your phone number (optional)", Order = 3)]
        public string? Phone { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Biography", Prompt = "Add a short bio...(optional)", Order = 4)]
        public string? Biography { get; set; }
    }
}
