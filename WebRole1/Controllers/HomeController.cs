using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebRole1.Models;

namespace WebRole1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Login()
        {
            ViewBag.LogMesage = "Logeate para utilizar nuestros servicios";
            return View();
        }

        public ActionResult SignIn()
        {
            ViewBag.SignMesage = "Registrate para que puedas acceder. Tus datos están protegidos";
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }


    }
}