using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class Expense
    {

        [Key]
        public int ExpenseId { get; set; }

        [Required(ErrorMessage = "This fiels can't be empty")]
        [DisplayName("Expense Ammount")]
        [Column(TypeName = "float")]
        public double ExpanceAmmount { get; set; }


        [Required(ErrorMessage = "This fiels can't be empty")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }


        [Required(ErrorMessage = "This fiels can't be empty")]
        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        //[DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime ExpenseDate { get; set; }


        [NotMapped]
        public string Category { get; set; }
    }
}
