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
        public AppUser Sender { get; set; } = null!;
        public string ReceiverName { get; set; } = null!;
        public string ReceiverPhone { get; set; } = null!;
        [Required]
        public int ParcelId { get; set; }

        [ForeignKey(nameof(ParcelId))]
        public virtual Parcel Parcel { get; set; } = null!;
        [Required]
        public int TrackingStatusId { get; set; }

        [ForeignKey(nameof(TrackingStatusId))]
        public virtual TrackingStatus TrackingStatus { get; set; } = null!;


        [ForeignKey(nameof(CollectionAddress))]
        public int CollectionAddressId { get; set; }

        public virtual CollectionAddress CollectionAddress { get; set; } = null!;

        [ForeignKey(nameof(DeliveryAddress))]
        public int DeliveryAddressId { get; set; }

        public virtual DeliveryAddress DeliveryAddress { get; set; } = null!;

        public string? CustomerMessage { get; set; }

    }
}
