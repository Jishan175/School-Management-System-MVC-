using SchoolManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementApp.Controllers
{
    public class AdminStudentController : Controller
    {
        // GET: AdminStudent
        private StudentRepository repository = new StudentRepository();
        // GET: Student
        public ActionResult Index()
        {
            return View(this.repository.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                this.repository.Insert(student);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }
        }

        public ActionResult Details(int id)
        {
            return View(this.repository.Get(id));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(this.repository.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                this.repository.Update(student);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit");
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(this.repository.Get(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            this.repository.Delete(id);
            return RedirectToAction("Index");


        }
    }
  }