using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GKBS_SUPPORT_UI.Controllers
{
    public class ReportsController : Controller
    {
        public ActionResult Index()
        {
            string APIurl = BL.clsEncryptDecrypt.Decrypt(ConfigurationManager.AppSettings["apiurl"].ToString());
            Session["APIurl"] = APIurl;
            return View();
        }
    }
}