using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExamsMarksController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExamsMarks
        public ActionResult Index()
        {
            ViewBag.StudentID = new SelectList(db.Students, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Exams_Marks data)
        {
            Exams_Marks ExamsMarks = new Exams_Marks();
            ExamsMarks.ExamID = data.ExamID;
            ExamsMarks.ExamClassSubject_id = data.ExamClassSubject_id;
            ExamsMarks.StudentID = data.StudentID;
            ExamsMarks.ObtainMarksA = data.ObtainMarksA;
            ExamsMarks.ObtainMarksB = data.ObtainMarksB;
            ExamsMarks.ObtainMarksPractical = data.ObtainMarksPractical;
            ExamsMarks.Remarks = data.Remarks;
            ExamsMarks.PassFail = data.PassFail;
            ExamsMarks.ExcludeSubject = data.ExcludeSubject;
            db.Exams_Marks.Add(ExamsMarks);
            db.SaveChanges();
            db.Entry(ExamsMarks).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}