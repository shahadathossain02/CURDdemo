using System.Collections.Generic;
using System.Web.Mvc;
using CURDdemo.BLL;
using CURDdemo.Models;

namespace CURDdemo.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        DepartmentBLL departmentBll=new DepartmentBLL();


        public ActionResult IndexForWebGrid()
        {
            List<Department> departments = departmentBll.GellAllDepartmentList();
            return View(departments);
        }


        public ActionResult Index()
        {
            List<Department> departments = departmentBll.GellAllDepartmentList();
            ViewBag.Department = departments;
            return View();
        }

        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveDepartmentInfo(Department department)
        {
            if (ModelState.IsValid)
            {
                string m = departmentBll.SaveDepartmentInfo(department);
            }
           
            //departmentBll.SaveDepartmentInfo(department);
            return RedirectToAction("Index", "Department");
        }
    }
}