using periodontist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace periodontist.Controllers
{
  public class HomeController : Controller
  {

    PeriodontistContext db = new PeriodontistContext();
    public ActionResult Index()
    {
      return View(db.UserQuestions);
    }


    [HttpPost]
    public JsonResult SendQuestion(UserQuestion question)
    {
      bool result = false;
      try
      {
        db.UserQuestions.Add(question);
        db.SaveChanges();
        result = true;
      }
      catch (Exception)
      {

        throw;
      }
     
      return Json(new
      {
        res=result
      });
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

    protected override void Dispose(bool disposing)
    {
      db.Dispose();
      base.Dispose(disposing);
    }
  }
}