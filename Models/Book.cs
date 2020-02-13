using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd_Final_Project.Models
{
    public class Book
    {
        [Required]
        public string BookName { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public string BookSubject { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(500)]
        public string Note { get; set; }

    }
}
