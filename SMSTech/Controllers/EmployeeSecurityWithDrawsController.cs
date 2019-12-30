using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class EmployeeSecurityWithDrawsController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: EmployeeSecurityWithDraws
        public ActionResult Index()
        {
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeeSecurityWithDraw data)
        {
            EmployeeSecurityWithDraw EmployeeSecurityWithDraw = new EmployeeSecurityWithDraw();
            EmployeeSecurityWithDraw.UserID = data.UserID;
            EmployeeSecurityWithDraw.SecurityWithdrawnByUser = data.SecurityWithdrawnByUser;            
            EmployeeSecurityWithDraw.CurrentDate = data.CurrentDate;
            EmployeeSecurityWithDraw.WithDrawOperatorID = data.WithDrawOperatorID;
            EmployeeSecurityWithDraw.WithDrawAmount = data.WithDrawAmount;
            EmployeeSecurityWithDraw.Remarks = data.Remarks;         
            EmployeeSecurityWithDraw.SalaryMonthID = data.SalaryMonthID;
            EmployeeSecurityWithDraw.RefundableTypeID = data.RefundableTypeID;
            db.EmployeeSecurityWithDraws.Add(EmployeeSecurityWithDraw);
            db.SaveChanges();
            db.Entry(EmployeeSecurityWithDraw).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}