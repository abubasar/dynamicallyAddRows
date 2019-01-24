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
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string DOB { get; set; }
    }
}