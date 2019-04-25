using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace periodontist.Areas.Admin.Controllers
{
    public class CabinetController : Controller
    {
        // GET: Admin/Cabinet
        public ActionResult Index()
        {
            return View();
        }
    }
}