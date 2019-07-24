using System;
using System.Linq;
using System.Linq.Expressions;

namespace HeiMa.OA.IDAL
{
    public interface IBaseDAL<T> where T : class ,new()
    {
        bool Add(T t);
        bool Update(T t);
        bool Delete(T t);
        IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> LoadPageEntities<S>(int pageSize, int pageIndex, out int totalCount, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderBy);
    }
}
