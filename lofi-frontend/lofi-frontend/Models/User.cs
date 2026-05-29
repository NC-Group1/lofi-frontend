using lofi_frontend.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace lofi_frontend.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required (ErrorMessage = "Please Enter Your Firstname")]
        public string FirstName { get; set; } = "";
        
        [Required(ErrorMessage = "Please Enter Your Lastname")]
        public string LastName { get; set; } = "";
        
        [Required(ErrorMessage = "Please Enter Your Email")]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Please Enter A Username")]
        public string Username { get; set; } = "";

        [Required(ErrorMessage = "Please Enter Your Password")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; } 

        [Required]
        public Gender Gender { get; set; } = Gender.PreferNotToSay;
        public List<Playlist> Playlists { get; set; } = new List<Playlist>();
    }

    public class UserLogin
    {
        [Required(ErrorMessage = "Please Enter Your Username")]
        public string Username { get; set; } = "";
        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; } = "";

    }
}
