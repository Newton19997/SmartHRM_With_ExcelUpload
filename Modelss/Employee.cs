using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelss
{
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salarywithbonus { get; set; }      
        
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
    }
}
