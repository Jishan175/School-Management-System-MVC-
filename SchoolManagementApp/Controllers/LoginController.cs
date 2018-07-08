using SchoolManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementApp.Controllers
{
    public class LoginController : Controller
    {
        private LoginRepository repository = new LoginRepository();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            Session.Abandon();
            Session.Remove("User");
            Session["User"] = null;
            return View();
        }
        // GET: Login
        [HttpPost]
        public ActionResult Create(string username,string password)
        {
            string usr = (string.IsNullOrEmpty(username) ? (char?)null : username[0]).ToString();
            if(usr.Equals("S"))
            {
                Student student=this.repository.GetStudent(username, password);
                if(student!=null)
                {
               
                    return RedirectToAction("Index","StudentOwn", new { area = "" });
                }
                AdminProfile admin = this.repository.GetAdmin(username, password);
                if (admin != null)
                {
                    Session["User"] = username;
                    Session.Timeout = 10;
                    return RedirectToAction("Index", "AdminHome", new { area = "" });
                }
            }
            else if(usr.Equals("E"))
            {
                Employee employee = this.repository.GetEmployee(username, password);
                if (employee != null)
                {
                    return RedirectToAction("Index", "EmployeeOwn", new { area = "" });
                }
                AdminProfile admin = this.repository.GetAdmin(username, password);
                if (admin != null)
                {
                    Session["User"] = username;
                    Session.Timeout = 10;
                    return RedirectToAction("Index", "AdminHome", new { area = "" });
                }
            }
            else
            {
                AdminProfile admin = this.repository.GetAdmin(username, password);
                if (admin != null)
                {
                    Session["User"] = username;
                    Session.Timeout = 10;
                    return RedirectToAction("Index", "AdminHome", new { area = "" });
                }
            }
            ViewBag.ErrorMessage = "Username and Password Doesn't Match";
            return View();

        }
    }
}