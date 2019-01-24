using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class SalesArea
    {
        public int Id { get; set; }

        public string  AreaCode { get; set; }

        public string Name { get; set; }

        public List<Customer> Customers { get; set; }
    }
}