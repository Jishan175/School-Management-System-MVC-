using SchoolManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementApp.Controllers
{
    public class AdminHomeController : Controller
    {
        

        //SchoolDBContext context = new SchoolDBContext();
        // GET: AdminHome

        public ActionResult Index()
        {
            if(Session["User"]!=null)
            {
                int countStudent = 0;
                int countEmployee = 0;
                using (var context = new SchoolDBContext())
                {
                    countStudent = context.Students.SqlQuery(" SELECT * FROM dbo.Students").Count();

                }
                ViewBag.CountStudent = countStudent;
                using (var context = new SchoolDBContext())
                {
                    countEmployee = context.Employees.SqlQuery(" SELECT * FROM dbo.Employees").Count();
                }

                ViewBag.CountEmployee = countEmployee;
                return View();
            }
            else
            {
                return RedirectToAction("Create", "AdminHome");
            }
           
        }
    }
}