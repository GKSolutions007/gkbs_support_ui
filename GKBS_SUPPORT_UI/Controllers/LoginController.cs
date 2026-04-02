using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GKBS_SUPPORT_UI.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            string APIurl = BL.clsEncryptDecrypt.Decrypt(ConfigurationManager.AppSettings["apiurl"].ToString());
            Session["APIurl"] = APIurl;
            return View();
        }


        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Signup()
        {
            var myData = new GKBS_SUPPORT_UI.Models.LoginModel();

            // 2. Fill it with data (otherwise CompanyName will be null/error)
            myData.CompanyName = "GKBS Support";
            myData.CompanyCode = "GKBS_001";
            myData.CompanyFSD = "2026";
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(string userid, string password, string repeat_password, string username, string email, string mobileno)
        {
            return RedirectToAction("Index");
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessForgot(string username, string email)
        {
            return RedirectToAction("Index");
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