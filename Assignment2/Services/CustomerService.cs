using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Services
{
    public class CustomerService
    {
        DataContext context = new DataContext();
        public List<CustomerViewModel> Search(string keyword)
        {
            IQueryable<Customer> customers = context.Customers.Include("SalesArea").AsQueryable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                customers = customers.Where(x => x.Name.ToLower().Contains(keyword.ToLower()) ||x.Phone.ToLower().Contains(keyword.ToLower()) || x.SalesArea.AreaCode.Contains(keyword.ToLower()));
            }
           // if (!string.IsNullOrWhiteSpace(request.Phone))
            //{
             //   customers = customers.Where(x => x.Phone.ToLower().Contains(request.Phone.ToLower()));
           // }
           // if (!string.IsNullOrWhiteSpace(request.AreaCode))
           // {
             //   customers = customers.Where(x => x.SalesArea.AreaCode.ToLower().Contains(request.AreaCode.ToLower()));
           // }
            customers = customers.OrderBy(x => x.Name);
           // if (!string.IsNullOrWhiteSpace(request.OrderBy))
           // {
            //    if (request.OrderBy.ToLower() == "name")
             //   {
             //       customers = request.IsAscending ? customers.OrderBy(x => x.Name) :customers.OrderByDescending(x => x.Name);
             //   }
              //  if (request.OrderBy.ToLower() == "phone")
               // {
                   // customers = req.IsAscending ? customers.OrderBy(x => x.Phone) : customers.OrderByDescending(x => x.Phone);
               // }
           // }
            
       customers = customers.Skip(0).Take(10);

            var list = customers.ToList().ConvertAll(x => new CustomerViewModel(x));

            return list;
        }
    }
}