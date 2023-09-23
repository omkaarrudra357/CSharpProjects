using MovieMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieMVC.Models
{
    public class TestDBContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            String conString = @"Server=200411LTP2873\SQLEXPRESS;Database=TestDB;integrated security=True;Encrypt=False;";
            options.UseSqlServer(conString);
        }
    }
}
