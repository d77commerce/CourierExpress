using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierExpress.Infrastructure.Models.Enums;

namespace CourierExpress.Infrastructure.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public EnumStatus EnumStatus  { get; set; }
        public DateTime DateTime { get; set; }= DateTime.Now;
        [Required]
        public string Info { get; set; } = string.Empty;
    }
}
