using System;
using System.Linq;
using System.Linq.Expressions;
using HeiMa.OA.Factory;
using HeiMa.OA.IDAL;

namespace HeiMa.OA.BLL
{
    public abstract class BaseService<T> where T : class,new()
    {
        private IDbSession dbSession;
        public BaseService()
        {
            dbSession = DbSessionFactory.GetDbSession();
            GetCurrentDbSession();
        }

        public IBaseDAL<T> CurrentDbSession;
        public abstract void GetCurrentDbSession();

        public bool Add(T t)
        {
            CurrentDbSession.Add(t);
            return dbSession.SaveChanges() > 0;
        }

        public bool Update(T t)
        {
            CurrentDbSession.Update(t);
            return dbSession.SaveChanges() > 0;
        }

        public bool Delete(T t)
        {
            CurrentDbSession.Delete(t);
            return dbSession.SaveChanges() > 0;
        }

        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDbSession.LoadEntities(whereLambda);
        }

        public IQueryable<T> LoadPageEntities<S>(int pageSize, int pageIndex, out int totalCount,
            Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderBy)
        {
            return CurrentDbSession.LoadPageEntities(pageSize, pageIndex, out  totalCount, whereLambda, isAsc, orderBy);
        }
    }
}
