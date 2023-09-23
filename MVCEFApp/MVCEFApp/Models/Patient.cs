using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MVCEFApp.Models
{
    public class Patient
    {
        [Key]
        [Column("doctorno")]

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,2)")]
        public long PhoneNumber { get; set; }
    }
}
