using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExamsGeneralRemarksController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExamsGeneralRemarks
        public ActionResult Index()
        {
            ViewBag.StudentID = new SelectList(db.Students, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Exams_GeneralRemarks data)
        {
            Exams_GeneralRemarks ExamsGeneralRemarks = new Exams_GeneralRemarks();
            ExamsGeneralRemarks.ExamID = data.ExamID;
            ExamsGeneralRemarks.StudentID = data.StudentID;
            ExamsGeneralRemarks.GeneralRemarks = data.GeneralRemarks;
            ExamsGeneralRemarks.Position = data.Position;
            ExamsGeneralRemarks.PositionInClass = data.PositionInClass;
            db.Exams_GeneralRemarks.Add(ExamsGeneralRemarks);
            db.SaveChanges();
            return Json("Saved Successfully");

        }
    }
}