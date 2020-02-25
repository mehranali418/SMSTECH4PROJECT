using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class EmployeeRefundableTypesController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: EmployeeRefundableTypes
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeeRefundableType data)
        {
            EmployeeRefundableType EmployeeRefundabletype = new EmployeeRefundableType();

            EmployeeRefundabletype.Name = data.Name;
            EmployeeRefundabletype.Detail = data.Detail;
            EmployeeRefundabletype.Status = data.Status;
            db.EmployeeRefundableTypes.Add(EmployeeRefundabletype);
            db.SaveChanges();
            return Json("Saved Successfully");
        }
    }
}