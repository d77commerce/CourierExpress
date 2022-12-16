using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierExpress.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourierExpress.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(p => p.IsActive)
                .HasDefaultValue(true);
            builder.HasData(CreateCustomers());
        }
        private List<AppUser> CreateCustomers()
        {
            var users = new List<AppUser>();
            var hasher = new PasswordHasher<AppUser>();

            var user = new AppUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "agent@mail.com",
                NormalizedUserName = "agent@mail.com",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "agent123");

            users.Add(user);

            user = new AppUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "guest123");

            users.Add(user);

            return users;
        }
    }
}
