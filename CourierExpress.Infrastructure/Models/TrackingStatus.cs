using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Infrastructure.Models
{
    public class TrackingStatus
    { 
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }= DateTime.Now;

        public Status Status { get; set; }

        public string? Info { get; set; }
     
    }
}
