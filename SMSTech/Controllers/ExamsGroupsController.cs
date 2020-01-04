using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExamsGroupsController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExamsGroups
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Exams_Groups data)
        {
            Exams_Groups ExamsGroups = new Exams_Groups();
            ExamsGroups.Name = data.Name;
            ExamsGroups.IsActive = data.IsActive;
            db.Exams_Groups.Add(ExamsGroups);
            db.SaveChanges();
            db.Entry(ExamsGroups).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}