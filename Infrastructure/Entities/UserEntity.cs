using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata;

namespace Infrastructure.Entities;

public class UserEntity : IdentityUser
{
    [ProtectedPersonalData]
    public string FirstName { get; set; } = null!;

    [ProtectedPersonalData]
    public string LastName { get; set; } = null!;

    [ProtectedPersonalData]
    public string? Biography { get; set; }

    [ProtectedPersonalData]
    public string? ProfileImageUrl { get; set; }

    public ICollection<AddressEntity> Addresses { get; set; } = new List<AddressEntity>();
}
