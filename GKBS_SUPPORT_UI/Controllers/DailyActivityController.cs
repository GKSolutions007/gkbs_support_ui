using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GKBS_SUPPORT_UI.Controllers
{
    public class DailyActivityController : Controller
    {
        public ActionResult Index()
        {
            string APIurl = BL.clsEncryptDecrypt.Decrypt(ConfigurationManager.AppSettings["apiurl"].ToString());
            Session["APIurl"] = APIurl;
            return View();
        }

        public ActionResult DailyActivity(int? taskId, string from, string Type, int? OrgId)
        {
            if (Session["LoginUserID"] == null)
                return RedirectToAction("Index", "Login");

            ViewBag.TaskId = taskId;
            ViewBag.From = from;
            ViewBag.Type = Type;
            ViewBag.OrgId = OrgId;

            return View();
        }
    }

}