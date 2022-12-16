﻿using System.ComponentModel.DataAnnotations;

namespace CourierExpress.Infrastructure.Models
{
    public class WorkerAddress
    {
        public WorkerAddress()
        {
            this.Workers = new HashSet<Worker>();
        }
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

        public virtual ICollection<Worker>? Workers { get; set; }     
    }
}
