using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(string name,string email,string phone,string address,string dob)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.DOB = dob;
                
        }
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }
    }
}