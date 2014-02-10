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
            SelectListItem item = new SelectListItem();
            List<SelectListItem> statusList = new List<SelectListItem>();

            item.Text = "-- Select Status --";
            item.Value = "0";
            statusList.Add(item);

            item = new SelectListItem();
            item.Text = "Active";
            item.Value = "1";
            statusList.Add(item);

            item = new SelectListItem();
            item.Text = "Inactive";
            item.Value = "2";
            statusList.Add(item);

            ViewBag.Status = new SelectList(statusList, "Value", "Text");
            return View(userList);
        }
    }
}
