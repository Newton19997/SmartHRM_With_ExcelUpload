using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modelss
{
   public class PoDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("PoHeader")]
        public int? PoId { get; set; }
        public virtual PoHeader PoHeader { get; set; }
        [Required]
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        [MaxLength(35)]
        public string Address { get; set; }

        [DisplayFormat(DataFormatString ="0:0.000")]
        [Column(TypeName ="smallmoney")]
        [Required]        
        public decimal price { get; set; }

      

       
    }
}

//Advance Master Detail CRUD in MVC ASP.NET CORE 6 using EFCORE -Purchase Order form
//https://www.youtube.com/watch?v=EpbpmDrn5lw