﻿using CourierExpress.Infrastructure.Data.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CourierExpress.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ParcelConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ManagerConfiguration());
            builder.ApplyConfiguration(new WorkerConfiguration());
            builder.ApplyConfiguration(new AddressConfiguration());
            builder.ApplyConfiguration(new BranchWorkerConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Worker> Workers { get; set; } = null!;
        public DbSet<Parcel> Parcels { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
    }
}
