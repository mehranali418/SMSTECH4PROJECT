using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class ExpenseCategoriesController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: ExpenseCategories
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(ExpenseCategory data)
        {
            ExpenseCategory ExamsGroups = new ExpenseCategory();
            ExamsGroups.Name = data.Name;
            db.ExpenseCategories.Add(ExamsGroups);
            db.SaveChanges();
            return Json("Saved Successfully");
        }
    }
}