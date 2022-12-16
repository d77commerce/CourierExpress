using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Infrastructure.Models
{
    public class DeliveryAddress
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Country { get; set; } = null!;
        [Required]
        public string City { get; set; } = null!;
        [Required]
        public string Street { get; set; } = null!;
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        [Required]
        public string Postcode { get; set; } = null!;
    }
}
