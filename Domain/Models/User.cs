using Microsoft.AspNetCore.Identity;

namespace Domain.Models;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Image { get; set; }
    public string City { get; set; }
    public bool IsLibraryOwner { get; set; }
    public Library Library { get; set; }
}
