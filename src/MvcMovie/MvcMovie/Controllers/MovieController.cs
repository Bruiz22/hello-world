using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class MovieController : Controller
    {
        // 
        // GET: /Movie/ 
        public string Index1()
        {
            return "This is my <b>default</b> action...";
        }
        public ActionResult Index()
        {
            return View();
        }      
        // 
        // GET: /Movie/Welcome/ 
        public string Welcome1()
        {
            return "This is the Welcome action method...";
        }
        public string Welcome2(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
        public string Welcome3(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
        public ActionResult Bienvenido(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}