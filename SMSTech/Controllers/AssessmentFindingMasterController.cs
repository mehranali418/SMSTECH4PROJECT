using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class AssessmentFindingMasterController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();

        // GET: AssessmentFindingMaster
        public ActionResult Index()
        {
            ViewBag.StudentID = new SelectList(db.Students, "ID", "Name");
            ViewBag.AssessmentCategoryID = new SelectList(db.AssessmentCategories, "ID", "Name");
            ViewBag.AssessmentColorID = new SelectList(db.AssessmentColors, "ID", "ColorName");
           

            return View();
        }
        [HttpPost]
        public ActionResult Insert(AssessmentFindingMaster data)
        {
            AssessmentFindingMaster Assessmentfindingmaster = new AssessmentFindingMaster();

            Assessmentfindingmaster.StudentID = data.StudentID;
            Assessmentfindingmaster.AssessmentCategoryID = data.AssessmentCategoryID;
            Assessmentfindingmaster.AssessmentColorID = data.AssessmentColorID;
            Assessmentfindingmaster.OperatorID = data.OperatorID;
            Assessmentfindingmaster.CreationDate = data.CreationDate;
            Assessmentfindingmaster.LastUpdatedOn = data.LastUpdatedOn;
            Assessmentfindingmaster.LastUpdatedBy = data.LastUpdatedBy;
            Assessmentfindingmaster.Editable = data.Editable;
            db.AssessmentFindingMasters.Add(Assessmentfindingmaster);
            db.SaveChanges();
            
            return Json("Saved Successfully");

        }
    }
}