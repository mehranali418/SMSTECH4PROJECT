using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExamsDateSheetNamesController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExamsDateSheetNames
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Exams_DateSheet_Names data)
        {
            Exams_DateSheet_Names ExamsDateSheetNames = new Exams_DateSheet_Names();
            ExamsDateSheetNames.Exam_id = data.Exam_id;
            ExamsDateSheetNames.Start_time = data.Start_time;
            db.Exams_DateSheet_Names.Add(ExamsDateSheetNames);
            db.SaveChanges();
            return Json("Saved Successfully");
        }
    }
}