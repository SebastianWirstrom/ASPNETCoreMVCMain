using System.ComponentModel.DataAnnotations;

namespace webbApp.ViewModels.Subscribers;

public class SubscribeViewModel
{
    public int Id { get; set; }

    [DataType(DataType.EmailAddress)]
    [Display(Name = "E-mail", Prompt = "Enter your E-mail")]
    [Required(ErrorMessage = "E-mail is required")]
    public string Email { get; set; } = null!;

    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekinReview { get; set; }
    public bool EventUpdates { get; set; }
    public bool StartupsWeekly { get; set; }
    public bool Podcasts { get; set; }
}
