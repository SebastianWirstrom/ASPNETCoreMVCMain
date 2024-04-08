using System.ComponentModel.DataAnnotations;

namespace webbApp.ViewModels.Subscribers;

public class SubscribeViewModel
{
    public int Id { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email address", Prompt = "Your E-mail")]
    public string Email { get; set; } = null!;

    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekinReview { get; set; }
    public bool EventUpdates { get; set; }
    public bool StartupsWeekly { get; set; }
    public bool Podcasts { get; set; }
}
