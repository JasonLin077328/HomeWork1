using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using HomeWork1.Models;

namespace HomeWork1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginVM oLoginVM,string ReturnUrl)
        {

            if (ModelState.IsValid)
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                oLoginVM.UserName,//你想要存放在 User.Identy.Name 的值，通常是使用者帳號
                DateTime.Now,
                DateTime.Now.AddMinutes(30),
                false,//將管理者登入的 Cookie 設定成 Session Cookie
                oLoginVM.UserName,//userdata看你想存放啥
                FormsAuthentication.FormsCookiePath);
                string encTicket = FormsAuthentication.Encrypt(ticket);

                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

                //FormsAuthentication.RedirectFromLoginPage(oLoginVM.UserName, false);
                if (ReturnUrl != string.Empty)
                {
                    return Redirect(ReturnUrl);
                }
                return RedirectToAction("Index", "客戶資料");
            }
            return View();
        }

        // GET: Logout
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("index");
        }
    }
}
