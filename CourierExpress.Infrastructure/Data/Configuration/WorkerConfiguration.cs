using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourierExpress.Infrastructure.Data.Configuration
{
   public class WorkerConfiguration  : IEntityTypeConfiguration<Worker>
     {
         public void Configure(EntityTypeBuilder<Worker> builder)
         {
             builder.HasData(new Worker()
             {
                 Id = 1,
                 UserId ="6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
             });
         }
     }
}
