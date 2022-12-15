using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierExpress.Infrastructure.Data;

namespace CourierExpress.Infrastructure.Models
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; } = null!;
        [Required]
        public ICollection<BranchWorker> BranchWorkers { get; set; } = null!;
    }
}
