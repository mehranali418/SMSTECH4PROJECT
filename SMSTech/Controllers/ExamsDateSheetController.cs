using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExamsDateSheetController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExamsDateSheet
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Exams_DateSheet data)
        {
            Exams_DateSheet ExamsDateSheet = new Exams_DateSheet();
            ExamsDateSheet.DateSheetName_id = data.DateSheetName_id;
            ExamsDateSheet.Section_id = data.Section_id;
            db.Exams_DateSheet.Add(ExamsDateSheet);
            db.SaveChanges();
            db.Entry(ExamsDateSheet).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}