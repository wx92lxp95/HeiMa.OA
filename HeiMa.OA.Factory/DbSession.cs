using HeiMa.OA.IDAL;

namespace HeiMa.OA.Factory
{
    public partial class DbSession : IDbSession
    {
        public int SaveChanges()
        {
            return DbContextFactory.GetCuurentDbContext().SaveChanges();
        }
    }
}
