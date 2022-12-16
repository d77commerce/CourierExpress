using Microsoft.AspNetCore.Identity;

namespace CourierExpress.Infrastructure.Models
{
    public class AppUser : IdentityUser<string>
    {
        public AppUser()
        {
            this.Orders = new HashSet<Orders>();
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual ICollection<Orders>? Orders { get; set; }
    }
}
