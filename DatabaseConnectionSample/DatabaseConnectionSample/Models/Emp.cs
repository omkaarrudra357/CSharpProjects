using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseConnectionSample.Models
{
    public class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [MinLength(1, ErrorMessage = "Name must have at least 1 chars")]
        public int Id { set; get; }


        [StringLength(25, ErrorMessage = "Title must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Title must have at least 3 chars")]
        [Required(ErrorMessage = "Title is Required")]
        public string Name { set; get; }



        [MinLength(1, ErrorMessage = "Name must have at least 1 chars")]
        public Decimal Salary { set; get; }


        [StringLength(25, ErrorMessage = "Title must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Title must have at least 3 chars")]
        [Required(ErrorMessage = "Title is Required")]
        public String City { set; get; }
    }
}
