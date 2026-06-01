using lofi_frontend.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace lofi_frontend.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required (ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; } = "";
        
        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; } = "";
        
        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Please enter a username")]
        public string Username { get; set; } = "";

        [Required(ErrorMessage = "Please enter your password")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; } = new DateTime(
            DateTime.Now.Year - 20, DateTime.Now.Month, DateTime.Now.Day);

        [Required]
        public Gender Gender { get; set; } = Gender.PreferNotToSay;
        public List<Playlist> Playlists { get; set; } = new List<Playlist>();
    }

    public class UserLogin
    {
        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; } = "";
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; } = "";

    }
}
