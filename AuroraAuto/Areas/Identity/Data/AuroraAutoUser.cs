using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AuroraAuto.Areas.Identity.Data
{
    public class AuroraAutoUser : IdentityUser
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
