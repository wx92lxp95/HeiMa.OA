using System.Web;
using HeiMa.OA.IDAL;

namespace HeiMa.OA.Factory
{
    public static class DbSessionFactory
    {
        public static IDbSession GetDbSession()
        {
            IDbSession dbSession = HttpContext.Current.Items["DbSession"] as DbSession;
            if (dbSession == null)
            {
                dbSession = new DbSession();
            }
            return dbSession;
        }
    }
}
