using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Core.Contracts
{
    internal interface IParcel
    {
        public double TotalKg { get; set; }
      
        public int Pieces { get; set; }
       
        public string PartsInfoJson { get; set; }
    }
}
