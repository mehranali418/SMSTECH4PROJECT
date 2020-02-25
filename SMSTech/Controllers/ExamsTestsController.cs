using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExamsTestsController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExamsTests
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Exams_Tests data)
        {
            Exams_Tests ExamsTests = new Exams_Tests();
            ExamsTests.Name = data.Name;
            ExamsTests.Detail = data.Detail;
            db.Exams_Tests.Add(ExamsTests);
            db.SaveChanges();
            return Json("Saved Successfully");
        }
    }
}