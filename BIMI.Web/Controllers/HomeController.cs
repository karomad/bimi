﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIMI.Web.Enums;
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

        ApplicationDbContext db = new ApplicationDbContext();
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
            List<JobModel> job = (from f in db.Jobs
                                  where f.isParent
                                  select f).ToList();

            lst.Jobs = job;
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
        public ActionResult GetJob(bool isParent)
        {
            ViewBag.IsParent = isParent;
            return View();
        }

        public ActionResult GetJobList(bool isParent, int type)
        {
            List<JobModel> job = (from f in db.Jobs
                                  where f.isParent == isParent && f.Type == type
                                  select f).ToList();
            foreach (var item in job)
            {
                var user = UserManager.FindById(item.UserId);
                item.FirstName = user.FirstName;
                item.LastName = user.LastName;
                item.Image = string.IsNullOrEmpty(user.Image) ? "" : user.Image.Replace("~/Files/UserImages/", "");
            }

            ViewBag.IsParent = isParent;

            return View(job);
        }

        [HttpGet]
        [Authorize]
        public ActionResult ChooseService(bool isParent)
        {
            ViewBag.IsParent = isParent;
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Service(ChooseserviceModel obj)
        {
            string id = User.Identity.GetUserId();
            bool t = UserManager.FindById(id).IsParent;
            int a = (int)obj.ServiceType;
            JobModel ob = new JobModel();
            ob.UserId = id;
            ob.Description = obj.Description;
            ob.MoneyRange = obj.MoneyRange;
            ob.Type = a;
            ob.isParent = t;
            db.Jobs.Add(ob);
            db.SaveChanges();
            return View("Index");
        }

    }
}