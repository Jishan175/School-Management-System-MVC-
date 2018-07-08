using SchoolManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementApp.Controllers
{
    public class AdminProfileController : Controller
    {
        // GET: AdminProfile
        private AdminProfileRepository repository = new AdminProfileRepository();

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
        public ActionResult Edit(AdminProfile profile)
        {
            if (Session["User"] != null)
            {
                if (ModelState.IsValid)
                {
                    this.repository.Update(profile);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("profile");
                }
            }
            else
            {
                return RedirectToAction("Create", "Login");
            }

        }
    }
}