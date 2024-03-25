using Microsoft.AspNetCore.Identity;

namespace AuroraAuto.Areas.Identity.Data
{
    public class AuroraAutoUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
