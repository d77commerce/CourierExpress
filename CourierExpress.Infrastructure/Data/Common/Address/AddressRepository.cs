namespace CourierExpress.Infrastructure.Data.Common.Address
{
    public class AddressRepository:Repository,IAddressRepository
    {
        public AddressRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}
