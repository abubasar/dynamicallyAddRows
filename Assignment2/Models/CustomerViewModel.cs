using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class CustomerViewModel
    {
        public CustomerViewModel(Customer customer)
        {
            Name = customer.Name;
            Phone = customer.Phone;
            AreaCode = customer.SalesArea.AreaCode;

        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AreaCode { get; set; }
    }
}