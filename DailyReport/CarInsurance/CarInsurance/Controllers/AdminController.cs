using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        // GET: Admin
        public ActionResult Dashboard()
        {
          
            return View(db.Insurees.ToList());
        }
    }
}