using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Infrastructure.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public IdentityUser Sender { get; set; } = null!;
        public string ReceiverName { get; set; } = null!;
        public string ReceiverPhone { get; set; } = null!;
        [Required]
        public int ParcelId { get; set; }

        [ForeignKey(nameof(ParcelId))]
        public Parcel Parcel { get; set; } = null!;
        [Required]
        public int TrackingStatusId { get; set; }

        [ForeignKey(nameof(TrackingStatusId))]
        public TrackingStatus TrackingStatus { get; set; } = null!;
        public int CollectionAddressId { get; set; }

        [ForeignKey(nameof(CollectionAddressId))]
        public Address CollectionAddress { get; set; } = null!;
        [Required]
        public int DeliveryAddressId { get; set; }

        [ForeignKey(nameof(DeliveryAddressId))]
        public Address DeliveryAddress { get; set; } = null!;

    }
}
