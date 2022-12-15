using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourierExpress.Infrastructure.Data.Configuration
{
    internal class BranchWorkerConfiguration : IEntityTypeConfiguration<BranchWorker>
    {
        public void Configure(EntityTypeBuilder<BranchWorker> builder)
        {
            builder.HasKey(k => new
            {
                k.WorkerId,
                k.BranchId
            });
            builder.HasOne(s => s.Worker)
                .WithMany(sb=>sb.BranchWorkers);
            builder.HasOne(s => s.Branch)
                .WithMany(sb => sb.BranchWorkers);
        }
    }
}
