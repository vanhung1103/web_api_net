using Microsoft.AspNetCore.Identity;

namespace hungpvph28127.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
