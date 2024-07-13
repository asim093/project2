using System.ComponentModel.DataAnnotations;
namespace landingpage.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string username { get; set; }

        [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d\-]+(\.[a-zA-Z]{2,})+$", ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }
}
