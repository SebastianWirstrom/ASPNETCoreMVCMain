using webbApp.ViewModels.Components;
namespace webbapp.ViewModels.Sections;

public class SwitchBetweenViewModel
{
    public string? Id { get; set; }
    public string? Title1 { get; set; }
    public string? Title2 { get; set; }
    public ImageViewModel ImageUrl { get; set; } = null!;
    public string AltText { get; set; } = null!;
}
