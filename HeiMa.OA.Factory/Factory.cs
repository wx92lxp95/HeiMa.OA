using System.Configuration;
using System.Reflection;
using HeiMa.OA.IDAL;

namespace HeiMa.OA.Factory
{
    public static class Factory
    {
        public static string Assemblywe = ConfigurationManager.AppSettings["Assembly"];
        public static IUserInfoDAL GetIUserInfo()
        {
            return Assembly.Load(Assemblywe).CreateInstance(Assemblywe + ".UserInfo", false) as IUserInfoDAL;
        }

        public static IOrderInfoDAL GetIOrderInfo()
        {
            return Assembly.Load(Assemblywe).CreateInstance(Assemblywe + ".OrderInfo", false) as IOrderInfoDAL;
        }
    }
}
