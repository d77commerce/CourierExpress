using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Infrastructure.Data.Common.Worker
{
    public class WorkerRepository:Repository,IWorkerRepository
    {
        public WorkerRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}
