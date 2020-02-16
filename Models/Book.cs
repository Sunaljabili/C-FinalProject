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
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }



        [Required]
        public int AuthorId { get; set; }

        public bool Status { get; set; }

        [Required]
        public decimal SalePrice { get; set; }

        [Required]
        public decimal RentPrice { get; set; }

        public DateTime CreatedAt { get; set; }

        public int Count { get; set; }

        public Author Author { get; set; }


    }
}
