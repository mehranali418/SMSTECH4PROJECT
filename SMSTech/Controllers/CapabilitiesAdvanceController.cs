using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class CapabilitiesAdvanceController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: CapabilitiesAdvance
        public ActionResult Index()
        {
            ViewBag.RoleID = new SelectList(db.Roles, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Capabilities_Advance data)
        {
            Capabilities_Advance CapabilitiesAdvance = new Capabilities_Advance();

            CapabilitiesAdvance.AdvanceCapabilityID = data.AdvanceCapabilityID;
            CapabilitiesAdvance.RoleID = data.RoleID;
            CapabilitiesAdvance.Status = data.Status;          
            db.Capabilities_Advance.Add(CapabilitiesAdvance);
            db.SaveChanges();
            
            return Json("Saved Successfully");

        }
    }
}