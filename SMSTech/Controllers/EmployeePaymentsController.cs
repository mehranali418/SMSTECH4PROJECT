using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class EmployeePaymentsController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: EmployeePayments
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeePayment data)
        {

            EmployeePayment Employeepayment = new EmployeePayment();          
            Employeepayment.EmployeeID = data.EmployeeID;
            Employeepayment.OperatorID = data.OperatorID;
            Employeepayment.AllowanceAmountID = data.AllowanceAmountID;           
            Employeepayment.AllowanceName = data.AllowanceName;
            Employeepayment.Dues = data.Dues;
            Employeepayment.Received = data.Received;                     
            Employeepayment.T_Date = data.T_Date;
            Employeepayment.Status = data.Status;
            Employeepayment.Remarks = data.Remarks;
            Employeepayment.SalaryMonthID = data.SalaryMonthID;
            Employeepayment.T_Type = data.T_Type;
            Employeepayment.ChequeNo = data.ChequeNo;
            Employeepayment.PenalityID = data.PenalityID;
            Employeepayment.PaymentMethod = data.PaymentMethod;
            Employeepayment.EmployeeSecurityInstallmentID = data.EmployeeSecurityInstallmentID;
            Employeepayment.Processesd = data.Processesd;
            db.EmployeePayments.Add(Employeepayment);
            db.SaveChanges();
            db.Entry(Employeepayment).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}