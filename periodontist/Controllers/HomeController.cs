using periodontist.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
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
        res = result
      });
    }

    [HttpPost]
    public async Task<JsonResult> Upload()
    {
      var res = "";
      var folderGuid = Guid.NewGuid();
      try
      {
        foreach (string file in Request.Files)
        {
          var fileContent = Request.Files[file];
          if (fileContent != null && fileContent.ContentLength > 0)
          {
            var fileName = fileContent.FileName;
            if (!Directory.Exists(Server.MapPath("~/Uploads/UserFiles/"+folderGuid)))
            {
              Directory.CreateDirectory(Server.MapPath("~/Uploads/UserFiles/"+ folderGuid));
            }
            var path = Path.Combine(Server.MapPath("~/Uploads/UserFiles/"), fileName);
            fileContent.SaveAs(path);
          }
        }
      }
      catch (Exception)
      {
        Response.StatusCode = (int)HttpStatusCode.BadRequest;
        return Json("Upload failed");
      }

      return Json(folderGuid);
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