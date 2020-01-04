using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExpenseAmountHistoryController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExpenseAmountHistory
        public ActionResult Index()
        {
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Insert(ExpenseAmount_History data)
        {
            ExpenseAmount_History ExpenseAmountHistory = new ExpenseAmount_History();
            ExpenseAmountHistory.Action = data.Action;
            ExpenseAmountHistory.ActionDate = data.ActionDate;
            ExpenseAmountHistory.ActionUserID = data.ActionUserID;
            ExpenseAmountHistory.ExpenseAmountID = data.ExpenseAmountID;
            ExpenseAmountHistory.AmountFrom = data.AmountFrom;
            ExpenseAmountHistory.AmountTo = data.AmountTo;
            ExpenseAmountHistory.ExpenseHeadID = data.ExpenseHeadID;
            ExpenseAmountHistory.UserID = data.UserID;
            ExpenseAmountHistory.T_Date = data.T_Date;
            ExpenseAmountHistory.SalaryMonthID = data.SalaryMonthID;
            ExpenseAmountHistory.Remarks = data.Remarks;
            ExpenseAmountHistory.ExpenseTitle = data.ExpenseTitle;
            db.ExpenseAmount_History.Add(ExpenseAmountHistory);
            db.SaveChanges();
            db.Entry(ExpenseAmountHistory).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}