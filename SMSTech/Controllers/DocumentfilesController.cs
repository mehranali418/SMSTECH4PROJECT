using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class DocumentfilesController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: Documentfiles
        public ActionResult Index()
        {
            ViewBag.StudentID = new SelectList(db.Students, "ID", "Name");
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Document_files data)
        {
            Document_files Documentfiles = new Document_files();

            Documentfiles.DocNameID = data.DocNameID;
            Documentfiles.FileName = data.FileName;
            Documentfiles.StudentID = data.StudentID;
            Documentfiles.UserID = data.UserID;          
            db.Document_files.Add(Documentfiles);
            db.SaveChanges();
            db.Entry(Documentfiles).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");

        }
    }
}