using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class EmployeeSecurityInstallmentsController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        
        // GET: EmployeeSecurityInstallments
        public ActionResult Index()
        {
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeeSecurityInstallment data)
        {
            EmployeeSecurityInstallment EmployeeSecurityInstallment = new EmployeeSecurityInstallment();
            EmployeeSecurityInstallment.UserID = data.UserID;
            EmployeeSecurityInstallment.OperatorID = data.OperatorID;
            EmployeeSecurityInstallment.Amount = data.Amount;
            EmployeeSecurityInstallment.DepositType = data.DepositType;
            EmployeeSecurityInstallment.CurrentDate = data.CurrentDate;
            EmployeeSecurityInstallment.Remarks = data.Remarks;
            EmployeeSecurityInstallment.EmployeePaymentID = data.EmployeePaymentID;
            EmployeeSecurityInstallment.SalaryMonthID = data.SalaryMonthID;           
            EmployeeSecurityInstallment.RefundableTypeID = data.RefundableTypeID;          
            db.EmployeeSecurityInstallments.Add(EmployeeSecurityInstallment);
            db.SaveChanges();
            return Json("Saved Successfully");
        }
    }
}