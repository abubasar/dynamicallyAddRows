using Assignment2.Models;
using Assignment2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class CustomerController : Controller
    {
        CustomerService service = new CustomerService();
        // GET: Customer
        public ActionResult Index(string keyword)
        {
            var list = service.Search(keyword);
            return View(list);
        }
    }
}