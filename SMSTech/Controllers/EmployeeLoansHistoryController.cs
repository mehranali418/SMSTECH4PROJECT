using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class EmployeeLoansHistoryController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: EmployeeLoansHistory
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeeLoans_History data)
        {
            EmployeeLoans_History EmployeeLoansHistory = new EmployeeLoans_History();
            EmployeeLoansHistory.Action = data.Action;
            EmployeeLoansHistory.ActionDate = data.ActionDate;
            EmployeeLoansHistory.ActionUserID = data.ActionUserID;          
            EmployeeLoansHistory.EmployeeID = data.EmployeeID;
            EmployeeLoansHistory.OperatorID = data.OperatorID;
            EmployeeLoansHistory.EmployeeLoansID = data.EmployeeLoansID;
            EmployeeLoansHistory.AllowanceName = data.AllowanceName;
            EmployeeLoansHistory.ReceivedLoanFrom = data.ReceivedLoanFrom;
            EmployeeLoansHistory.ReceivedLoanTo = data.ReceivedLoanTo;
            EmployeeLoansHistory.ReturnedLoanFrom = data.ReturnedLoanFrom;
            EmployeeLoansHistory.ReturnedLoanTo = data.ReturnedLoanTo;
            EmployeeLoansHistory.T_Date = data.T_Date;
            EmployeeLoansHistory.Remarks = data.Remarks;
            EmployeeLoansHistory.SalaryMonthID = data.SalaryMonthID;
            EmployeeLoansHistory.ChequeNo = data.ChequeNo;
            EmployeeLoansHistory.PaymentMethod = data.PaymentMethod;
            EmployeeLoansHistory.Processesd = data.Processesd;
            db.EmployeeLoans_History.Add(EmployeeLoansHistory);
            db.SaveChanges();
            db.Entry(EmployeeLoansHistory).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}