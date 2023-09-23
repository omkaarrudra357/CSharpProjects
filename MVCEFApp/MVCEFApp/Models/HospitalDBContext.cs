using MVCEFApp.Models;
using Microsoft.EntityFrameworkCore;


namespace MVCEFApp.Models
{
    public class HospitalDBContext: DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            String conString = @"Server=200411LTP2873\SQLEXPRESS;Database=HospitalDB;integrated security=True;Encrypt=False;";
            options.UseSqlServer(conString);
        }

    }
}
