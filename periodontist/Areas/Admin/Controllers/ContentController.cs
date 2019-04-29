using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;
namespace periodontist.Areas.Admin.Controllers
{
    [Authorize]
    public class ContentController : Controller
    {
        private Logger _logger = LogManager.GetLogger("admin");

        // GET: Admin/Content
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddArticle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddArticle(string titlearticle, string content)
        {
            var username = System.Web.HttpContext.Current.User.Identity.Name;


            return View();
        }
    }
}