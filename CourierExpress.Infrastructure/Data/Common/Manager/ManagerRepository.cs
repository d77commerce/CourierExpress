namespace CourierExpress.Infrastructure.Data.Common.Manager
{
    public class ManagerRepository : Repository ,IManagerRepository
    {
        public ManagerRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}
