using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelss.ViewModels
{
   public class SpEmployeeInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salarywithbonus { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
        public string IsBonusAdded { get; set; }
    }
}
