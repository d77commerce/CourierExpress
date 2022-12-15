using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Infrastructure.Models
{
    public class BranchWorker
    {
        [Key, Column(Order = 1)]
        public int WorkerId { get; set; }
        [Key, Column(Order = 2)]
        public int BranchId { get; set; }
        public Worker? Worker { get; set; }
        public Branch? Branch { get; set; }
    }
}
