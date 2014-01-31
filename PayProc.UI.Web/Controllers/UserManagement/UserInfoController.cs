using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayProc.Domain.Contract;
using PayProc.Domain.Manager;

namespace PayProc.UI.Web.Controllers
{
    public class UserInfoController : Controller
    {
        private IUserManager usrDetailsMgr;

        public UserInfoController()
        {

        }

        public UserInfoController(IUserManager usrMgr)
        {
            usrDetailsMgr = usrMgr;
        }

        public ActionResult Index()
        {
            var userList = usrDetailsMgr.FindUserList(0, 15);
            return View(userList);
        }
    }
}
