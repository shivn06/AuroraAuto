using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AuroraAuto.Models;
using Microsoft.AspNetCore.Identity;

namespace AuroraAuto.Areas.Identity.Data
{
    public class AuroraAutoUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
