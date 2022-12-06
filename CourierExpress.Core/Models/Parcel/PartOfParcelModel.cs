﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierExpress.Core.Contracts;

namespace CourierExpress.Core.Models.Parcel
{
    public class PartOfParcelModel :IPartOfParcel
    {
        public double Kg { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public bool IsFragile { get; set; }
    }
}
