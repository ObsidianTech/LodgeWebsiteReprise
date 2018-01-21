using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LodgeWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Officers()
        {
            return View();
        }
        public ActionResult Bylaws()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}