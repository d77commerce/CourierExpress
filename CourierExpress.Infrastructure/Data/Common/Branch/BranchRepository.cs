using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Infrastructure.Data.Common.Branch
{
  public class BranchRepository : Repository,IBranchRepository
    {
        public BranchRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}
