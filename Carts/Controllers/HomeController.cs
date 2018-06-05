using FoodBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodBasket.Controllers
{
    public class HomeController : Controller
    {

        CartContext dbObj = new CartContext();
        public ActionResult Index()
        {
            if (Session["userID"] != null)
            {
                var userName = Session["userID"].ToString();
                var getUser = dbObj.Users.FirstOrDefault((n) => n.Username == userName);
                if (getUser != null)
                {
                    return View(getUser);
                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Register()
        {

            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(Register userObj) 
        {
            if (ModelState.IsValid)
            {
                Session["userID"] = userObj.Username;
                dbObj.Users.Add(userObj);
                dbObj.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Register");
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            Session["userID"] = null;
            return View("login");
        }

        [HttpPost]
        public ActionResult Login(Login userobj) //authenticates/validatezs login details
        {

            if (ModelState.IsValid)
            {
                var getuser = dbObj.Users.FirstOrDefault((p) => p.Username == userobj.Username && p.Password == userobj.Password);
                if (getuser != null)
                {
                    Session["userID"] = userobj.Username;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.LoginFail = "Invalid username or password";
                    return View("login");
                }
            }
            else
            {
                return View("login", userobj);
            }
        }

        public string GetUserByUsername(string uname) //find if user exists
        {
            var userExist = "";
            var user = dbObj.Users.FirstOrDefault((n) => n.Username == uname);
            if (user == null)
            {
                userExist = "No";
            }
            else
            {
                userExist = "Yes";
            }
            return userExist;
        }
    }
}