using System;
using System.ComponentModel.DataAnnotations;


namespace BackEnd_Final_Project.Models
{
    public class Manager
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [MaxLength(50)]
        public string CreatedBy { get; set; }
    }
}
