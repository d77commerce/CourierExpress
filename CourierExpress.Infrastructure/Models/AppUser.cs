using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CourierExpress.Infrastructure.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            this.Orders = new HashSet<Orders>();
        }

        public bool IsActive { get; set; } = false;
        public virtual ICollection<Orders>? Orders { get; set; }
    }
}
