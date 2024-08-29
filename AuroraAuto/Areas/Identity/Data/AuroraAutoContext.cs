using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuroraAuto.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }

public DbSet<AuroraAuto.Models.Customer> Customer { get; set; } = default!;

public DbSet<AuroraAuto.Models.Cart> Cart { get; set; } = default!;

public DbSet<AuroraAuto.Models.Category> Category { get; set; } = default!;

public DbSet<AuroraAuto.Models.Order> Order { get; set; } = default!;

public DbSet<AuroraAuto.Models.Payment> Payment { get; set; } = default!;

public DbSet<AuroraAuto.Models.Product> Product { get; set; } = default!;



    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<AuroraAutoUser>
    {
        public void Configure(EntityTypeBuilder<AuroraAutoUser> builder)

        {
            builder.Property(u => u.FirstName).HasMaxLength(20);
            builder.Property(u => u.LastName).HasMaxLength(20);
        }
    }
}
