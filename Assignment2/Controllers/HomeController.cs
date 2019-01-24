using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

             Dictionary<string, Employee> employeeList = new Dictionary<string,Employee>();
            for (int i = 0; i < 5; i++)
             {
              employeeList.Add(Convert.ToString(i),new Employee());
            }

            ViewBag.i = 3;
            EmployeeViewModel model = new EmployeeViewModel() { Employees = employeeList };
            return View(model);
        }
        public ActionResult Post(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                //
            }

            List<Employee> employees = model.Employees.Select(x => x.Value).ToList();
            return View();
        }

        [HttpGet]
        public ActionResult AddNewRow()
        {
            Dictionary<string, Employee> employeeList = new Dictionary<string, Employee>();

            employeeList.Add(Guid.NewGuid().ToString(), new Employee());

            EmployeeViewModel model = new EmployeeViewModel() { Employees = employeeList };
            return PartialView("_AddNewRow",model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        

    }
}