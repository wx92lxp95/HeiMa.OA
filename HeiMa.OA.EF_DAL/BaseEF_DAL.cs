using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using HeiMa.OA.Factory;

namespace HeiMa.OA.EF_DAL
{
    public class BaseEF_DAL<T> where T : class,new()
    {
        private DbContext db;
        public BaseEF_DAL()
        {
            db = DbContextFactory.GetCuurentDbContext();
        }

        public bool Add(T t)
        {
            db.Entry(t).State = EntityState.Added;
            return true;
        }

        public bool Update(T t)
        {
            db.Entry(t).State = EntityState.Modified;
            return true;
        }

        public bool Delete(T t)
        {
            db.Entry(t).State = EntityState.Deleted;
            return true;
        }

        #region 查询
        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return db.Set<T>().Where(whereLambda).AsQueryable();
        }

        //分页
        public IQueryable<T> LoadPageEntities<S>(int pageSize, int pageIndex,
                                                  out int totalCount,
            Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderBy)
        {
            IQueryable<T> temp = db.Set<T>().Where(whereLambda).AsQueryable();

            totalCount = temp.Count();

            if (isAsc)
            {
                temp = temp.OrderBy(orderBy)
                           .Skip(pageSize * (pageIndex - 1))
                           .Take(pageSize).AsQueryable();
            }
            else
            {
                temp = temp.OrderByDescending(orderBy)
                          .Skip(pageSize * (pageIndex - 1))
                          .Take(pageSize).AsQueryable();
            }
            return temp;
        }
        #endregion
    }
}
