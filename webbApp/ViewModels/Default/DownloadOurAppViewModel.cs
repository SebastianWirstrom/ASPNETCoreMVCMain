using webbApp.ViewModels.Components;

namespace webbApp.ViewModels.Sections;

public class DownloadOurAppViewModel
{
    public string? Id { get; set; }
    public string Title { get; set; } = null!;
    public ImageViewModel MainImageBottom { get; set; } = null!;
    public ImageViewModel MainImageTop { get; set; } = null!;
    public string AltText { get; set; } = null!;
}
