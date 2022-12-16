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
    internal class ParcelConfiguration :IEntityTypeConfiguration<Parcel>
    {
        public void Configure(EntityTypeBuilder<Parcel> builder)
        {
            builder.HasData(new Parcel()
            {
                Id = 1,
                TotalKg = 3.540,
                Pieces = 2,
            
            });
        }
    }
}
