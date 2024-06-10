using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuroraAuto.Models;

namespace AuroraAuto.Areas.Identity.Data;

public class AuroraAutoContext : IdentityDbContext<IdentityUser>
{
    public AuroraAutoContext(DbContextOptions<AuroraAutoContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<AuroraAuto.Models.Cart> Cart { get; set; } = default!;

public DbSet<AuroraAuto.Models.Category> Category { get; set; } = default!;
}
