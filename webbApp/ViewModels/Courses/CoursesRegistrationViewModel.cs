using System.ComponentModel.DataAnnotations;

namespace webbApp.ViewModels.Courses;

public class CoursesRegistrationViewModel
{
    [Required]
    [Display(Name = "Title")]
    public string Title { get; set; } = null!;

    [Display(Name = "Price")]
    public string? Price { get; set; }

    [Display(Name = "Discount price")]
    public string? DiscountPrice { get; set; }

    [Display(Name = "Hours")]
    public string? Hours { get; set; }

    [Display(Name = "Is a bestseller")]
    public bool IsBestSeller { get; set; } = false;

    [Display(Name = "Likes in numbers")]
    public string? LikesInNumbers { get; set; }

    [Display(Name = "Likes in percent")]
    public string? LikesInPercent { get; set; }

    [Display(Name = "Author ")]
    public string? Author { get; set; }
}
