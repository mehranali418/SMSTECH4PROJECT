using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class EmployeePaymentsHistoryController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: EmployeePaymentsHistory
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeePayments_History data)
        {

            EmployeePayments_History EmployeePaymentsHistory = new EmployeePayments_History();
            EmployeePaymentsHistory.Action = data.Action;
            EmployeePaymentsHistory.ActionDate = data.ActionDate;
            EmployeePaymentsHistory.ActionUserID = data.ActionUserID;
            EmployeePaymentsHistory.EmployeePaymentsID = data.EmployeePaymentsID;
            EmployeePaymentsHistory.EmployeeID = data.EmployeeID;
            EmployeePaymentsHistory.OperatorID = data.OperatorID;
            EmployeePaymentsHistory.AllowanceAmountID = data.AllowanceAmountID;           
            EmployeePaymentsHistory.AllowanceName = data.AllowanceName;
            EmployeePaymentsHistory.DuesFrom = data.DuesFrom;
            EmployeePaymentsHistory.DuesTo = data.DuesTo;
            EmployeePaymentsHistory.ReceivedFrom = data.ReceivedFrom;
            EmployeePaymentsHistory.ReceivedTo = data.ReceivedTo;
            EmployeePaymentsHistory.T_Date = data.T_Date;
            EmployeePaymentsHistory.Status = data.Status;
            EmployeePaymentsHistory.Remarks = data.Remarks;
            EmployeePaymentsHistory.SalaryMonthID = data.SalaryMonthID;
            EmployeePaymentsHistory.T_Type = data.T_Type;
            EmployeePaymentsHistory.T_Type = data.T_Type;
            EmployeePaymentsHistory.ChequeNo = data.ChequeNo;
            EmployeePaymentsHistory.PenalityID = data.PenalityID;
            EmployeePaymentsHistory.Processesd = data.Processesd;
            EmployeePaymentsHistory.Processesd = data.Processesd;
            db.EmployeePayments_History.Add(EmployeePaymentsHistory);
            db.SaveChanges();
            db.Entry(EmployeePaymentsHistory).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
    }
}
}