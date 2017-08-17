using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repair.Models;
using System.Data.Entity;

namespace Repair.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult SaveRecord(Property model)
        {
            FaultyEntities db = new FaultyEntities();

            return View();
        }
    }
}