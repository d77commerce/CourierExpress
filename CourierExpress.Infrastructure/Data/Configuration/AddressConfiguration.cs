using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierExpress.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourierExpress.Infrastructure.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<CollectionAddress>
    {
        public void Configure(EntityTypeBuilder<CollectionAddress> builder)
        {
            builder.HasData(new CollectionAddress()
            {
                Id = 1,
                Country = "Bulgaria",
                City = "Sofia",
                Street = "Nezabravka",
                Postcode = "1000"
            });
        }
    }
}
