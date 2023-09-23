using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace MovieMVC.Models
{
    public class Movie
    {
        [Key]
        [Column("ID")]

        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Hero { get; set; }
        public string Director { get; set; }
        public string MusicDirector { get; set; }
        public DateTime ReleaseDate { get; set;}
        public int Cost { get; set; }
        public int Collection { get; set; }
        public int Review { get; set; }
        
    }
}
