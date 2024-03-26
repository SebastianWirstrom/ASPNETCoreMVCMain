using webbApp.ViewModels.Components;

namespace webbApp.ViewModels.Sections;

public class ManageYourWorkViewModel
{
    public string? Id { get; set; }
    public string Title { get; set; } = null!;
    public string Text1 { get; set; } = null!;
    public string Text2 { get; set; } = null!;
    public string Text3 { get; set; } = null!;
    public string Text4 { get; set; } = null!;
    public string Text5 { get; set; } = null!;
    public ImageViewModel Image { get; set; } = null!;
    public LinkViewModel Link { get; set; } = null!;
}
