using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelss
{
   public class MExcelFile
    {
        [Key]
        public int Id { get; set; }
        public int CustomerCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
    }
}
