using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress.Core.Contracts
{
    internal interface IAddress
    {
        
        public int Id { get; set; }
       
        public string Country { get; set; } 
   
        public string City { get; set; }
    
        public string Street { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
      
        public string Postcode { get; set; } 
    }
}
