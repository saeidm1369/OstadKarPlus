using Microsoft.AspNetCore.Identity;

namespace OstadKarPlus.Domain.Core.UsersAgg.Entities
{
    public class AppUser : IdentityUser
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string InternationCode { get; set; }
    }
}
