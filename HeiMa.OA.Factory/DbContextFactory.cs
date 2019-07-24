using System.Web;
using System.Data.Entity;
using HeiMa.OA.Model;

namespace HeiMa.OA.Factory
{
    public static class DbContextFactory
    {
        public static DbContext GetCuurentDbContext()
        {
            DbContext db = HttpContext.Current.Items["DbContext"] as DbContext;
            if (db == null)
            {
                db = new DbContextEntities();
                HttpContext.Current.Items.Add("DbContext", db);
            }
            return db;
        }
    }
}
