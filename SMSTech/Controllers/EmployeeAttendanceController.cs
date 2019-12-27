using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class EmployeeAttendanceController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: EmployeeAttendance
        public ActionResult Index()
        {
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeeAttendance data)
        {
            EmployeeAttendance Employeeattendance = new EmployeeAttendance();
            Employeeattendance.UserID = data.UserID;
            Employeeattendance.sDate = data.sDate;
            Employeeattendance.OperatorID = data.OperatorID;
            Employeeattendance.UpdateDate = data.UpdateDate;
            Employeeattendance.Remarks = data.Remarks;
            Employeeattendance.Status = data.Status;
            Employeeattendance.Type = data.Type;
            Employeeattendance.Present = data.Present;
            Employeeattendance.Absent = data.Absent;
            Employeeattendance.Leave = data.Leave;
            Employeeattendance.Offday = data.Offday;           
            db.EmployeeAttendances.Add(Employeeattendance);
            db.SaveChanges();
            db.Entry(Employeeattendance).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}