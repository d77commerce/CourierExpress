using CourierExpress.Infrastructure.Data.Configuration;
using Microsoft.AspNetCore.Identity;
using CourierExpress.Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CourierExpress.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser,IdentityRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ParcelConfiguration());
            builder.ApplyConfiguration(new PartsOfParcelConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ManagerConfiguration());
            builder.ApplyConfiguration(new WorkerConfiguration());
            builder.ApplyConfiguration(new AddressConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Worker> Workers { get; set; } = null!;
        public DbSet<Parcel> Parcels { get; set; } = null!;
       
    }
}
