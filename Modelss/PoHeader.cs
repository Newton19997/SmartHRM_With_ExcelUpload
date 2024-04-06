using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modelss
{
   public class PoHeader
    {
        //public PoHeader()
        //{
        //    PoDetails = new List<PoDetail>();
        //}
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string PoNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PoDate { get; set; }

        [Required]
        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public List<PoDetail> PoDetails { get; set; } = new List<PoDetail>();
    }
}
