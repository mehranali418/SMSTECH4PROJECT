using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExamsGradeController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExamsGrade
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Exams_Grade data)
        {
            Exams_Grade ExamsGrade = new Exams_Grade();
            ExamsGrade.Percentage_from = data.Percentage_from;
            ExamsGrade.Percentage_to = data.Percentage_to;
            ExamsGrade.Grade_letters = data.Grade_letters;
            ExamsGrade.Level_id = data.Level_id;
            db.Exams_Grade.Add(ExamsGrade);
            db.SaveChanges();
            return Json("Saved Successfully");

        }
    }
}