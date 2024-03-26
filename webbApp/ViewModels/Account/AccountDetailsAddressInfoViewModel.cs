using System.ComponentModel.DataAnnotations;

namespace webbApp.ViewModels.Account
{
    public class AccountDetailsAddressInfoViewModel
    {
        [Display(Name = "Address line 1", Prompt = "Enter your address line", Order = 0)]
        [Required(ErrorMessage = "Address is required")]
        [DataType(DataType.Text)]
        public string AddressLine_1 { get; set; } = null!;

        [Display(Name = "Address line 2 (optional)", Prompt = "Enter your second address line", Order = 1)]
        [DataType(DataType.Text)]
        public string? AddressLine_2 { get; set; }

        [Display(Name = "Postal code", Prompt = "Enter your Postal code", Order = 0)]
        [Required(ErrorMessage = "Postal code is required")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; } = null!;

        [Display(Name = "City", Prompt = "Enter your city", Order = 1)]
        [Required(ErrorMessage = "City is required")]
        [DataType(DataType.Text)]
        public string City { get; set; } = null!;
    }
}
