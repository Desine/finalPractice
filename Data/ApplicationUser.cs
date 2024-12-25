using Microsoft.AspNetCore.Identity;

namespace finalPractice.Data;

public class ApplicationUser : IdentityUser
{
    public string? Name { get; set; }
    public string? Sex { get; set; }
    public DateOnly? BirthDate { get; set; }
    public string? Address { get; set; }
    public string? BIO { get; set; }
    public string? Pictures { get; set; }
}
