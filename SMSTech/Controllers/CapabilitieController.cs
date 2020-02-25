using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class CapabilitieController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: Capabilitie
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Capability data)
        {
            Capability capability = new Capability();

            capability.RoleID = data.RoleID;
            capability.Name = data.Name;
            capability.isRoot = data.isRoot;
            capability.Allowed = data.Allowed;
            db.Capabilities.Add(capability);
            db.SaveChanges();
            
            return Json("Saved Successfully");

        }
    }
}