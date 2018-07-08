using SchoolManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementApp.Controllers
{
    public class AdminEmployeeController : Controller
    {
        private EmployeeRepository repository = new EmployeeRepository();
        // GET: Employee
        public ActionResult Index()
        {
            if (Session["User"] != null)
            {
                return View(this.repository.GetAll());
            }
            else
            {
                return RedirectToAction("Create", "Login");
            }


        }
        [HttpGet]
        public ActionResult Create()
        {
            if (Session["User"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Create", "Login");
            }

        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (Session["User"] != null)
            {
                if (ModelState.IsValid)
                {
                    this.repository.Insert(employee);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Create");
                }
            }
            else
            {
                return RedirectToAction("Create", "Login");
            }


        }

        public ActionResult Details(int id)
        {
            if (Session["User"] != null)
            {
                return View(this.repository.Get(id));
            }
            else
            {
                return RedirectToAction("Create", "Login");
            }


        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (Session["User"] != null)
            {
                return View(this.repository.Get(id));
            }
            else
            {
                return RedirectToAction("Create", "Login");
            }


        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (Session["User"] != null)
                {
                    this.repository.Update(employee);
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Create", "Login");
                }


            }
            else
            {
                return View("Create");
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (Session["User"] != null)
            {
                return View(this.repository.Get(id));
            }
            else
            {
                return RedirectToAction("Create", "Login");
            }


        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            if (Session["User"] != null)
            {
                this.repository.Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create", "Login");
            }




        }

    }
}