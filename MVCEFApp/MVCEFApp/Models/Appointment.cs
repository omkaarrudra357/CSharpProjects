using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MVCEFApp.Models
{
    public class Appointment
    {
        [Key]
        [Column("appointmentno")]

        [Required]
        public int Id { get; set; }
        [Required]
        public string PatientId { get; set; } = string.Empty;
        [Required]
        public string DoctorId { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfAppointment { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,2)")]
        public bool Status { get; set; }
    }
}
