using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

    namespace BackEnd_Final_Project.Models
{
   public class Customer
    {
        public int Id { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        public string Phone { get; set; }

        
    }
}
