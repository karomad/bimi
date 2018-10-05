using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIMI.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace BIMI.Web.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationUserManager _userManager;

        public const string Parrent = "Parent";
        public const string Worker = "Worker";
        public HomeController()
        {
        }

        public HomeController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
        }


        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        public ActionResult Index()
        {
            MainPageViewModel lst = new MainPageViewModel();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                List<JobModel> job = (from f in db.Jobs
                                      where f.isParent select f).ToList();

                lst.Jobs = job;
            }
            return View(lst);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //test
            return View();
        }

        public ActionResult GetParentJob()
        {
            return View();
        }
        public ActionResult GetWorkerJob()
        {
            return View();
        }

        public ActionResult GetJobList(int type)
        {

            return View();
        }

    }
}