using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExpenseAmountsController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExpenseAmounts
        public ActionResult Index()
        {
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name");
            return View();
        }
         [HttpPost]
        public ActionResult Insert(ExpenseAmount data)
        {
            ExpenseAmount Expenseamount = new ExpenseAmount();                       
            Expenseamount.ExpenseHeadID = data.ExpenseHeadID;
            Expenseamount.UserID = data.UserID;
            Expenseamount.T_Date = data.T_Date;
            Expenseamount.Amount = data.Amount;
            Expenseamount.SalaryMonthID = data.SalaryMonthID;
            Expenseamount.Remarks = data.Remarks;
            Expenseamount.ExpenseTitle = data.ExpenseTitle;
            db.ExpenseAmounts.Add(Expenseamount);
            db.SaveChanges();
            db.Entry(Expenseamount).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}