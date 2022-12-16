using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierExpress.Infrastructure.Models.Enums;

namespace CourierExpress.Infrastructure.Models
{
    public class TrackingStatus
    {
        public TrackingStatus()
        {
            this.StatusCollection = new HashSet<Status>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateTime { get; set; }= DateTime.Now;

        [Required] 
        public virtual ICollection<Status> StatusCollection { get; set; } = null!;
        [Required]
        public string Info { get; set; } = "Thanks ! ! !";

    }
}
