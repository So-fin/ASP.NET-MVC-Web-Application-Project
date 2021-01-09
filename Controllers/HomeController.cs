using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    [Authorize]

    public class HomeController : Controller
    {
        
        public ActionResult employee(int id)
        {
            Employeecontext _DbCon = new Employeecontext();
            employee emp = _DbCon.Emp.Single(s => s.EmpId == id);
            return View(emp);
        }

        public ActionResult Link()
        {
            Employeecontext _DbCon = new Employeecontext();
            List<employee> emps = _DbCon.Emp.ToList();
            return View(emps);

        }

        public ActionResult employeeList()
        {
            Employeecontext _DbCon = new Employeecontext();
            var employee = _DbCon.Emp.ToList();
            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(employee employee)
        {
            Employeecontext _DbCon = new Employeecontext();
            _DbCon.Emp.Add(employee);
            _DbCon.SaveChanges();
            string message = "Success";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        public ActionResult Edit(int id)
        {
            Employeecontext _DbCon = new Employeecontext();
            var emp = _DbCon.Emp.Where(s => s.EmpId == id).FirstOrDefault();
            TempData["Employee"] = id;
            TempData.Keep();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(employee employee)
        {
             Employeecontext _Dbcon = new Employeecontext();

            int id = (int)TempData["Employee"];

            var emp = _Dbcon.Emp.Where(x => x.EmpId == id).FirstOrDefault();

            emp.Email = employee.Email;
            emp.gender = employee.gender;
            emp.Name = employee.Name;
            _Dbcon.SaveChanges();

            var employeeList = _Dbcon.Emp.ToList();
            return View("EmployeeList", employeeList);
        }

        public ActionResult Delete(int id)
        {
            Employeecontext _Dbcon = new Employeecontext();

            var emp = _Dbcon.Emp.Where(x => x.EmpId == id).FirstOrDefault();
            _Dbcon.Emp.Remove(emp);
            _Dbcon.SaveChanges();

            var employeeList = _Dbcon.Emp.ToList();
            return View("EmployeeList", employeeList);
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Feedback feedback)
        {
            Employeecontext _DbCon = new Employeecontext();
            _DbCon.dbset.Add(feedback);
            _DbCon.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

    }
}