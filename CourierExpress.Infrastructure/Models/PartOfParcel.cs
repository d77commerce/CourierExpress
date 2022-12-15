using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Infrastructure.Models
{
    public class PartOfParcel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Kg { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Length { get; set; }
        [Required]
        public bool IsFragile { get; set; }
    }
}
