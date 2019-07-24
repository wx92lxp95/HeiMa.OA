using System.Linq;
using System.Web.Mvc;
using HeiMa.OA.IBLL;

namespace HeiMA.OA.UI.Portal.Controllers
{
    public class HomeController : Controller
    {
        public IUserInfoService IUserInfoService { get; set; }
        public ActionResult Index()
        {
            //IUserInfoService IUserInfo = new HeiMa.OA.BLL.UserInfoService();
            var data = IUserInfoService.LoadEntities(u => true).ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}