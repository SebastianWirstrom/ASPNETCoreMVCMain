using System.ComponentModel.DataAnnotations;

namespace webbApp.ViewModels.Subscribers;

public class UnsubscribeViewModel
{
    [Required(ErrorMessage = "Enter a valid E-mail address to unsubscribe")]
    [EmailAddress]
    [Display(Name = "Email address", Prompt = "Your E-mail")]
    public string Email { get; set; } = null!;
}
