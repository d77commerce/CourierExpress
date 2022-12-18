using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierExpress.Core.Contracts;
using CourierExpress.Core.Models.Order;
using CourierExpress.Infrastructure.Data.Common;
using CourierExpress.Infrastructure.Models;
using Microsoft.Extensions.Logging;

namespace CourierExpress.Core.Services
{
    
    public class OrderServices :IOrderServices, IEnumerable
    {
        private readonly Repository repo;
        private readonly ILogger logger;

        public async Task CallCourier(Order order)
        {
            var form = new Order();
            await repo.AddAsync(form);
        }

        public async Task TrackById(int orderId)
        {
            TrackingStatus status = await repo.GetByIdAsync<TrackingStatus>(orderId);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
