using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourierExpress.Infrastructure.Models
{
    public class CollectionAddress
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
