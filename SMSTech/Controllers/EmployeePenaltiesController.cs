using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class EmployeePenaltiesController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: EmployeePenalties
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeePenalty data)
        {
            EmployeePenalty EmployeePenalty = new EmployeePenalty();

            EmployeePenalty.Name = data.Name;
            EmployeePenalty.Detail = data.Detail;          
            db.EmployeePenalties.Add(EmployeePenalty);
            db.SaveChanges();
            return Json("Saved Successfully");

        }
    }
}