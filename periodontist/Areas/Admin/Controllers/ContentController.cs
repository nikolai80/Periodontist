using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using NLog;
using periodontist.Areas.Admin.Models;
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

        [HttpPost]
        public JsonResult GetAllArticles()
        {
            var res = false;
            var users=UserManager.Users;
            var articles = mng.GetAllArticles().Select(x => new ArticleViewModel
                {
                    Title = x.Title,
                    Text = x.Text,
                    Date = x.Date,
                    AuthorName = UserManager.Users.Where(u=>u.Id==x.AuthorID).First().UserName
                }).ToList();;
            if (articles.Count>0)
            {
                res=true;
            }

            return Json(new
            {
                result = res,
                data = articles
            });
        }

        [HttpGet]
        public ActionResult AddArticle()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddArticle(string titlearticle, string content)
        {
            var res = false;
            var userName = System.Web.HttpContext.Current.User.Identity.Name;
            ApplicationUser authenticatedUser = UserManager.Users.Where(u => u.UserName == userName).First();

            res = mng.CreateArticle(new Article
            {
                Title = titlearticle,
                Text = content,
                Date = DateTime.Now.Date,
                AuthorID = authenticatedUser.Id
            });

            return Json(new
            {
                result = res
            });
        }
    }
}