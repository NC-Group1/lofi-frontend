using System.ComponentModel.DataAnnotations;
using Google.Apis.YouTube.v3.Data;
using lofi_frontend.Models.Enum;

namespace lofi_frontend.Models
{
    public class UserData
    {
        public UserData() 
        {
            Id = string.Empty;
            Username = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Dob = new DateTime(DateTime.Now.Year - 20, 1, 1);
            Gender = Gender.PreferNotToSay;
            Playlists = [];
        }

        public UserData(string id, string username, string firstName, string lastName, string email, 
            DateTime age, Gender gender = 0)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Dob = new DateTime(DateTime.Now.Year - 20, 1, 1);
            Gender = gender;
            Playlists = [];
        }

        public string Id { get; set; } = string.Empty;
        [Required]
        public string Username { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public List<Playlist> Playlists { get; set; } = new List<Playlist>();
    }

    public class AuthToken
    {
        public AuthToken() {
            Id = string.Empty;
            AccessToken = string.Empty;
            TokenType = string.Empty;
            RefreshToken = string.Empty;
            ExpiresIn = string.Empty;
            ExpiresAt = string.Empty;
        }

        public AuthToken(string id, string accessToken, string tokenType, string refreshToken, string expiresIn, string expiresAt)
        {
            Id = id;
            AccessToken = accessToken;
            TokenType = tokenType;
            RefreshToken = refreshToken;
            ExpiresIn = expiresIn;
            ExpiresAt = expiresAt;
        }

        public string Id { get; set; }
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public string RefreshToken { get; set; }
        public string ExpiresIn { get; set; }
        public string ExpiresAt { get; set; }
    }

    public class AuthenticatedUser
    {
        public AuthenticatedUser() 
        { 
            UserData = new UserData();
            AuthToken = new AuthToken();
        }

        public AuthenticatedUser(UserData user, AuthToken authToken)
        {
            UserData = user;
            AuthToken = authToken;
        }

        public UserData UserData { get; set; }
        public AuthToken AuthToken { get; set; }
    }

    public class UserWithPassword
    {
        public UserWithPassword() 
        {
            UserData = new UserData();
            Password = string.Empty;
        }

        public UserWithPassword(UserData user, string password)
        {
            UserData = user;
            Password = password;
        }

        public UserData UserData { get; set; }
        public string Password { get; set; }
    }
}
