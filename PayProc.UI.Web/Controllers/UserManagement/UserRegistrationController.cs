namespace PayProc.UI.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using PayProc.Domain.Contract;
    using PayProc.Models.ViewModel;

    public class UserRegistrationController : Controller
    {
        private readonly IUserManager usrManager;

        public UserRegistrationController()
        {

        }

        public UserRegistrationController(IUserManager usrMgr)
        {
            usrManager = usrMgr;
        }

        public ActionResult Index()
        {
            return View(new UserInfo());
        }

        public ActionResult SaveUserInformation(UserInfo usrInfoDetail)
        {
            usrManager.SaveUserInfo(usrInfoDetail);
            ViewBag.result = "Data Saved Successfully";
            return View(); 
        }
    }
}
