using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class CommitmentsController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: Commitments
        public ActionResult Index()
        {
            ViewBag.StudentID = new SelectList(db.Students, "ID", "Name");
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Commitment data)
        {
            Commitment commitment = new Commitment();

            commitment.StudentID = data.StudentID;
            commitment.UserID = data.UserID;
            commitment.sDate = data.sDate;
            commitment.Details = data.Details;
            db.Commitments.Add(commitment);
            db.SaveChanges();
           
            return Json("Saved Successfully");

        }
    }
}