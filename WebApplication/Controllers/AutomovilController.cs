using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class AutomovilController : Controller
    {
        // GET: Automovil
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var da = new dbAutomivil();
            var list = da.Getlist();

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}