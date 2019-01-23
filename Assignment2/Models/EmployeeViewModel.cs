using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class EmployeeViewModel
    {
        public Dictionary<string, Employee> Employees { get; set; }
      

        public EmployeeViewModel()
        {
            Employees = new Dictionary<string, Employee>();
           
        }
    }
}