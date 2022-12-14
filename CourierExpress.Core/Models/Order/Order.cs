using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using CourierExpress.Core.Contracts;
using CourierExpress.Core.Models.Parcel;
using CourierExpress.Core.Template;
using CourierExpress.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;

namespace CourierExpress.Core.Models.Order
{
    public class Order : IOrder, IEnumerable
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public IdentityUser Sender { get; set; } = null!;
        public string ReceiverName { get; set; } = null!;
        public string ReceiverPhone { get; set; } = null!;
        public ParcelModel Parcel { get; set; }=null!;
        public TrackingStatus TrackingStatus { get; set; }
        public Address.Address CollectionAddress { get; set; } = null!;
        public Address.Address DeliveryAddress { get; set; } = null!;

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
