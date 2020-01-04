using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExpenseHeadsController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExpenseHeads
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(ExpenseHead data)
        {
            ExpenseHead Expensehead = new ExpenseHead();
            Expensehead.Name = data.Name;
            Expensehead.ExpenseCategoryID = data.ExpenseCategoryID;
            db.ExpenseHeads.Add(Expensehead);
            db.SaveChanges();
            db.Entry(Expensehead).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}