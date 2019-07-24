namespace HeiMa.OA.IDAL
{
    public interface IDbSession
    {
        IUserInfoDAL IUserInfo { get; }
        IOrderInfoDAL IOrderInfo { get; }
        int SaveChanges();
    }
}
