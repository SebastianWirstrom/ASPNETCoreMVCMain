using Infrastructure.Entities;
using System.ComponentModel.DataAnnotations;

namespace webbApp.ViewModels.Account;

public class AccountDetailsViewModel
{
    public ProfileInfoViewModel ProfileInfo { get; set; } = null!;
    public AccountDetailsBasicInfoViewModel BasicInfo { get; set; } = null!;
    public AccountDetailsAddressInfoViewModel AddressInfo { get; set; } = null!;
}
