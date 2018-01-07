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
        public ActionResult Featured_articles()     //精选文章
        {
            return View();
        }
    }
}