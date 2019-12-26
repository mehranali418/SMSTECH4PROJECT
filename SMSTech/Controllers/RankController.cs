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
    public class RankController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        Rank rank = new Rank();

        //
        // GET: /Rank/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetRank()
        {
            var rank = db.Ranks.ToList();
            return Json(rank, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Insert(Rank data)
        {
            Rank rank = new Rank();

            rank.Name = data.Name;
            db.Ranks.Add(rank);
            db.SaveChanges();
            db.Entry(rank).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}