using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GKBS_SUPPORT_UI.Controllers
{
    public class CustomerController: Controller
    {
        public ActionResult Index()
        {
            string APIurl = BL.clsEncryptDecrypt.Decrypt(ConfigurationManager.AppSettings["apiurl"].ToString());
            Session["APIurl"] = APIurl;
            return View();
        }


        [HttpPost]
        public JsonResult SetSession(string userID, string userName)
        {
            Session["LoginUserID"] = userID;
            Session["UserName"] = userName;

            DataTable dtPermission = new DataTable();
            dtPermission.Columns.Add("MenuID");
            Session["dtPermission"] = dtPermission;

            return Json(new { success = true });
        }

    }
}