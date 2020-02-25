using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExamsClassSubjectsController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExamsClassSubjects
        public ActionResult Index()
        {
            ViewBag.SectionID = new SelectList(db.Sections, "ID", "Name");

            return View();
        }
        [HttpPost]
        public ActionResult Insert(Exams_ClassSubjects data)
        {
            Exams_ClassSubjects ExamsClassSubjects = new Exams_ClassSubjects();
            ExamsClassSubjects.TestID = data.TestID;
            ExamsClassSubjects.SectionID = data.SectionID;
            ExamsClassSubjects.SubjectID = data.SubjectID;
            ExamsClassSubjects.SubjectNumber = data.SubjectNumber;
            ExamsClassSubjects.TotalMarks = data.TotalMarks;
            ExamsClassSubjects.PassingMarks = data.PassingMarks;        
            db.Exams_ClassSubjects.Add(ExamsClassSubjects);
            db.SaveChanges();
            return Json("Saved Successfully");
        }
    }
}