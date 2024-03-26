using webbApp.ViewModels.Components;

namespace webbApp.ViewModels.Sections;

public class TopWorkToolsViewModel
{
    public string? Id { get; set; }
    public string Title { get; set; } = null!;
    public string Text { get; set; } = null!;
    public List<ImageViewModel> Tools { get; set; } = null!;
}
