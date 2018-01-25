using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Google_guide.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()     //主页
        {
            return View();
        }
        public ActionResult Featured_articles()     //精选文章页面
        {
            return View();
        }
        public ActionResult Article_Google_1()     //精选文章内容页面_1
        {
            return View();
        }
        public ActionResult Recruitment()     //招贤纳士
        {
            return View();
        }
        public ActionResult Agreement()     //用户协议
        {
            return View();
        }
        public ActionResult Business()      //商务合作
        {
            return View();
        }
    }
}