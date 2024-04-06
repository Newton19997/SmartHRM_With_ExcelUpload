using Microsoft.AspNetCore.Mvc.Rendering;
using Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Models
    
{
    public class DropModel
    {
        public int Id { get; set; }
        public ICollection<SelectListItem> Customers { get; set; }
        public List<Employee> Employees { get; set; }  
        public int SelectedCustomer { get; set; }
        public int SelectedEmployee { get; set; }

    }
}
//list drop down
////https://www.youtube.com/watch?v=L-QApsV85ug