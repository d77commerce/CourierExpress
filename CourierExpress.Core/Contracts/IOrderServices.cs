using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierExpress.Core.Models.Order;

namespace CourierExpress.Core.Contracts
{
    public interface IOrderServices
    {
        Task CallCourier(Order order);
    }
}
