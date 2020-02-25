using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExamsGroupCollectionsController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExamsGroupCollections
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Exams_GroupCollections data)
        {
            Exams_GroupCollections ExamsGroupCollections = new Exams_GroupCollections();
            ExamsGroupCollections.Group_id = data.Group_id;
            ExamsGroupCollections.Exam_id = data.Exam_id;
            ExamsGroupCollections.Percentage = data.Percentage;
            ExamsGroupCollections.SequenceNumber = data.SequenceNumber;
            db.Exams_GroupCollections.Add(ExamsGroupCollections);
            db.SaveChanges();
            return Json("Saved Successfully");

        }
    }
}