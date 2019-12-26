using Newtonsoft.Json.Linq;
using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ReligionController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();

      
        // GET: /Religions/
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetReligion()
        {
            var Religion = db.Religions.ToList();
            return Json(Religion, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Insert(Religion data)
        {
            Religion religion = new Religion();

            religion.Name = data.Name;     
            db.Religions.Add(religion);
            db.SaveChanges();
            db.Entry(religion).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");

        }

    }
}