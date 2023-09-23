using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SecondMVCApp.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public int NoOfBooks { set; get; }
        public String AuthorName { set; get; }
        public String RoyaltyCompany { set; get; }
    }
}
