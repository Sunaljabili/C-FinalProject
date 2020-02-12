using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd_Final_Project
{
   public class Report
    {
        public int İd { get; set; }

        [Required]
        public int Managerİd { get; set; }

        [Required]
        public string CustomerId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime DeadLine { get; set; }

        [MaxLength(500)]
        public  string Note { get; set; }

        [Required]
        public bool IsDone { get; set; }

       
        public int? DoneUserId { get; set; }

        public DateTime DoneAt { get; set; }

        [Required]
        [MaxLength(500)]
        public string Result { get; set; }

       


    }
}
