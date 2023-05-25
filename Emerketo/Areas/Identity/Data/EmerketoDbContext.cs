using Emerketo.Areas.Identity.Data;
using Emerketo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Emerketo.Areas.Identity.Data;

public class EmerketoDbContext : IdentityDbContext<EmerketoUser>
{
    public EmerketoDbContext(DbContextOptions<EmerketoDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new EmerketoUserEntityConfiguration());
    }
}

public class EmerketoUserEntityConfiguration : IEntityTypeConfiguration<EmerketoUser>
{
	void IEntityTypeConfiguration<EmerketoUser>.Configure(EntityTypeBuilder<EmerketoUser> builder)
	{
        builder.Property(u => u.FirstName);
		builder.Property(u => u.LastName);
	}
}

