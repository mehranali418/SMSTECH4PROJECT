using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class EmployeeLoansController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: EmployeeLoans
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeeLoan data)
        {
            EmployeeLoan Employeeloan = new EmployeeLoan();
            Employeeloan.EmployeeID = data.EmployeeID;
            Employeeloan.OperatorID = data.OperatorID;
            Employeeloan.AllowanceName = data.AllowanceName;
            Employeeloan.ReceivedLoan = data.ReceivedLoan;
            Employeeloan.ReturnedLoan = data.ReturnedLoan;
            Employeeloan.T_Date = data.T_Date;
            Employeeloan.Remarks = data.Remarks;
            Employeeloan.SalaryMonthID = data.SalaryMonthID;
            Employeeloan.ChequeNo = data.ChequeNo;
            Employeeloan.PaymentMethod = data.PaymentMethod;
            Employeeloan.Processesd = data.Processesd;
            db.EmployeeLoans.Add(Employeeloan);
            db.SaveChanges();
            db.Entry(Employeeloan).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}