namespace CourierExpress.Infrastructure.Data.Common.Parcel
{
    public class ParcelRepository : Repository, IParcelRepository
    {
        public ParcelRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}
