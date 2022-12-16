using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourierExpress.Infrastructure.Models
{
    public class Branch
    {
        public Branch()
        {
            this.BranchWorkers = new HashSet<Worker>();
        }
       
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public BranchAddress Address { get; set; } = null!;

        [Required]
        public virtual ICollection<Worker> BranchWorkers { get; set; }
    }
}
