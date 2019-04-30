using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using NLog;
using periodontist.BLL.Managers;
using periodontist.Models;

namespace periodontist.Areas.Admin.Controllers
{
    [Authorize]
    public class ContentController : Controller
    {
        private Logger _logger = LogManager.GetLogger("admin");
        ArticleManager mng = new ArticleManager();
        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

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
            var userName = System.Web.HttpContext.Current.User.Identity.Name;
            ApplicationUser authenticatedUser =UserManager.Users.Where(u=>u.UserName==userName).First();

            mng.CreateArticle(new Models.Article
            {
                Title = titlearticle,
                Text = content,
                Date = DateTime.Now.Date,
                Author = authenticatedUser
            });

            return View();
        }
    }
}