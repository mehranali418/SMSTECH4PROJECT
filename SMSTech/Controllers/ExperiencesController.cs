using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExperiencesController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: Experiences
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Experience data)
        {
            Experience experience = new Experience();
            experience.Name = data.Name;
            db.Experiences.Add(experience);
            db.SaveChanges();
            return Json("Saved Successfully");
        }
    }
}