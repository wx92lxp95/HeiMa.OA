using HeiMa.OA.Factory;
using HeiMa.OA.IBLL;
namespace HeiMa.OA.BLL
{
    public partial class OrderInfoService : BaseService<Model.OrderInfo>, IOrderInfoService
    {
        public override void GetCurrentDbSession()
        {
            CurrentDbSession = new DbSession().IOrderInfo;
        }
    }
    public partial class UserInfoService : BaseService<Model.UserInfo>, IUserInfoService
    {
        public override void GetCurrentDbSession()
        {
            CurrentDbSession = new DbSession().IUserInfo;
        }
    }
    //public partial class UserRoleService : BaseService<Model.UserRole>, IUserRoleService
    //{
    //    public override void GetCurrentDbSession()
    //    {
    //        CurrentDbSession = new DbSession().IUserRole;
    //    }
    //}
}