using Infrastructure.Entities;
using System.ComponentModel.DataAnnotations;

namespace webbApp.ViewModels.Account;

public class AccountDetailsViewModel
{
    public ProfileInfoViewModel? ProfileInfo { get; set; } 
    public AccountDetailsBasicInfoViewModel? BasicInfo { get; set; } 
    public AccountDetailsAddressInfoViewModel? AddressInfo { get; set; } 
}
