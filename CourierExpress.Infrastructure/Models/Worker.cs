using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourierExpress.Infrastructure.Models
{
    public class Worker
    {
        public Worker()
        {
            this.Branches = new HashSet<Branch>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; } = null!;
     

        public virtual ICollection<Branch> Branches { get; set; } = null!;
    }
}
