using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCapp.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [StringLength(25, ErrorMessage = "Title must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Title must have at least 3 chars")]
        [Required(ErrorMessage = "Title is Required")]
        public int NoOfBooks { set; get; }
        [MinLength(1, ErrorMessage = "Name must have at least 1 chars")]
        public String AuthorName { set; get; }
        public String RoyaltyCompany { set; get; }
    }
}

