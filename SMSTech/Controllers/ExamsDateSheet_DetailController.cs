using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExamsDateSheet_DetailController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExamsDateSheet_Detail
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Exams_DateSheet_Detail data)
        {
            Exams_DateSheet_Detail ExamsDateSheetDetail = new Exams_DateSheet_Detail();
            ExamsDateSheetDetail.DateSheet_id = data.DateSheet_id;
            ExamsDateSheetDetail.ExamClassSubject_id = data.ExamClassSubject_id;
            ExamsDateSheetDetail.Paper_date = data.Paper_date;
            db.Exams_DateSheet_Detail.Add(ExamsDateSheetDetail);
            db.SaveChanges();
            db.Entry(ExamsDateSheetDetail).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}