using System.ComponentModel.DataAnnotations;

namespace webbApp.ViewModels.Subscribers;

public class UnsubscribeViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email address", Prompt = "Your E-mail")]
    public string Email { get; set; } = null!;
}
