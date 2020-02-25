using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class DocumentnamesController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: Documentnames
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Document_names data)
        {
            Document_names Documentnames = new Document_names();

            Documentnames.Name = data.Name;
            Documentnames.DocType = data.DocType;            
            db.Document_names.Add(Documentnames);
            db.SaveChanges();
            
            return Json("Saved Successfully");

        }
    }
}