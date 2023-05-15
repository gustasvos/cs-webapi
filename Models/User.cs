using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreMysql.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "This field can not be blank")]
        [StringLength(128, MinimumLength = 2, ErrorMessage = "Must have at least 3 characteres")]
        public string FirstName { get; set; }

        [StringLength(128)]
        public string? LastName { get; set; }
        
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Birth date is required")]
        public DateTime DateOfBirth { get; set; }

    }
}