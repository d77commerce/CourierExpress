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
        public bool IsActive { get; set; } = false;
        public ICollection<Orders>? Orders { get; set; }
    }
}
