using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.EL.Models;
using Test.BL;


namespace TestAssessment.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var userBL = new UserActions();
            var userData = userBL.UserList();
            return View(userData);
                
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User obj)
        {
            var userBL = new UserActions();
            userBL.AddUser(obj);
            return RedirectToAction("Index");


        }

        public ActionResult Details()
        {
            return View();
        }


    }
}