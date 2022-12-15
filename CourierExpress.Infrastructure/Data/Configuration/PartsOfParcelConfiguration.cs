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
    internal class PartsOfParcelConfiguration : IEntityTypeConfiguration<PartOfParcel>
    {
        public void Configure(EntityTypeBuilder<PartOfParcel> builder)
        {
            builder.HasData(new PartOfParcel()
            {
                Id = 1,
                Kg = 2.300,
                IsFragile = false
            });
        }
    }
}
