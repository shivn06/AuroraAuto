using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuroraAuto.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuroraAuto.Areas.Identity.Data;

public class AuroraAutoContext : IdentityDbContext<AuroraAutoUser>
{
    public AuroraAutoContext(DbContextOptions<AuroraAutoContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
        });

        builder.Entity<IdentityRole>().HasData(
        new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" }
        );

        var harsher = new PasswordHasher<AuroraAutoUser>();
        builder.Entity<AuroraAutoUser>().HasData(

            new AuroraAutoUser
            {
                Id = "1",
                FirstName = "Shiv",
                LastName = "Naidu",
                UserName = "admin@auroraauto.com",
                NormalizedUserName = "ADMIN@AURORAAUTO.COM",
                Email = "admin@auroraauto.com",
                NormalizedEmail = "ADMIN@AURORAAUTO.COM",
                EmailConfirmed = true,
                PasswordHash = harsher.HashPassword(null, "Admin123")
            }

        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { RoleId = "1", UserId = "1" }
        );

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


