using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEFApp.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Speciality { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,2)")]
        public decimal VisitingFees { get; set; }
        public long PhoneNumber { get; set; }
    }
}
