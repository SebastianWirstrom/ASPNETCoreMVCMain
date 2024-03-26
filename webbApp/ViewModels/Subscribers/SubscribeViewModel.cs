using System.ComponentModel.DataAnnotations;

namespace webbApp.ViewModels.Subscribers;

public class SubscribeViewModel
{
    [Required]
    [Display(Name = "Subscribe", Prompt = "Enter your E-mail address")]
    public string Email { get; set; } = null!;
    public bool IsSubscribed { get; set; } = false;
}
