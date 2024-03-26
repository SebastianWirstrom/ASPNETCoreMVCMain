using webbapp.ViewModels.Sections;
using webbApp.ViewModels.Sections;

namespace webbApp.ViewModels.Views;

public class DefaultIndexViewModel
{
    public string Title { get; set; } = "";
    public ShowcaseViewModel Showcase { get; set; } = null!;
    public FeaturesViewModel Features { get; set; } = null!;
    public SwitchBetweenViewModel SwitchBetween { get; set; } = null!;
    public ManageYourWorkViewModel ManageYourWork { get; set;} = null!;
    public DownloadOurAppViewModel DownloadOurApp { get; set; } = null!;
    public TopWorkToolsViewModel TopWorkTools { get; set; } = null!;
    public NewsletterViewModel Newsletter { get; set; } = null!;
}
