using webbApp.ViewModels.Components;

namespace webbApp.ViewModels.Sections;

public class NewsletterViewModel
{
    public string? Id { get; set; }
    public string Title { get; set; } = null!;
    public LinkViewModel Link { get; set; } = null!;
    public LinkViewModel LinkTerms { get; set; } = null!;
    public LinkViewModel LinkPrivacy { get; set; } = null!;
    public ImageViewModel Image { get; set; } = null!;   
}
