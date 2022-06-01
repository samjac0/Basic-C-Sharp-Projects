using CarInsurance_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {

         using (InsuranceEntities db = new InsuranceEntities())
     
         return View(db.Insurees.ToList());
        }



    }
}