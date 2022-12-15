using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Infrastructure.Models
{
    public class Parcel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(0.100, 100.000)]
        public double TotalKg { get; set; }
        [Required]
        [Range(1, 100)]
        public int Pieces { get; set; }
        [Required]
        public int PartsId { get; set; }

        [ForeignKey(nameof(PartsId))]
        public PartOfParcel Parts { get; set; } = null!;
    }
}
