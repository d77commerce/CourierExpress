﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Core.Contracts
{
    public interface IOrder
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }

    }
}
