using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Core.Contracts
{
    public interface IParcel
    {
      
      
        public int Pieces { get; set; }
       
    }
}
