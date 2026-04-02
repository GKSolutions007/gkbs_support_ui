using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GKBS_SUPPORT_UI.Controllers
{
    public class ReportsNewController : Controller
    {
        // GET: ReportsNew
        public ActionResult Index()
        {
            if (Session["LoginUserID"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
        }
    }
}