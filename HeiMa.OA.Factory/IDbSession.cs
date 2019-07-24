using HeiMa.OA.IDAL;
namespace HeiMa.OA.Factory
{
    public partial class DbSession : IDbSession
    {
        private IOrderInfoDAL _iOrderInfo;
        public IOrderInfoDAL IOrderInfo
        {
            get
            {
                if (_iOrderInfo == null)
                {
                    _iOrderInfo = Factory.GetIOrderInfo();
                }
                return _iOrderInfo;
            }
        }

        private IUserInfoDAL _iUserInfo;
        public IUserInfoDAL IUserInfo
        {
            get
            {
                if (_iUserInfo == null)
                {
                    _iUserInfo = Factory.GetIUserInfo();
                }
                return _iUserInfo;
            }
        }

        //private IUserRoleDAL _iUserRole;
        //public IUserRoleDAL IUserRole
        //{
        // get
        // {
        //    if (_iUserRole == null)
        //    {
        //        _iUserRole = Factory.GetIUserRole();
        //    }
        //    return _iUserRole;
        //    }
        //}
    }
}