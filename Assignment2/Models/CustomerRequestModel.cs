using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class CustomerRequestModel
    {
        public CustomerRequestModel()
        {
            
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AreaCode { get; set; }

        public string OrderBy { get; set; }

        public bool IsAscending { get; set; }

        public string Keyword { get; set; }
    }
}