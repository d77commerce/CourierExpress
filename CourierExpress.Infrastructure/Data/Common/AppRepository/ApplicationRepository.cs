namespace CourierExpress.Infrastructure.Data.Common.AppRepository
{
    public class ApplicationRepository : Repository, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext context)
        {
            Context = context;
        }
    }
}
