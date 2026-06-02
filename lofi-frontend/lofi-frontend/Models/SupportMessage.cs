using lofi_frontend.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace lofi_frontend.Models
{
    public class SupportMessage
    {
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        public string PhoneNumber { get; set; } = string.Empty;
        public CountryCode SelectedCountry { get; set; } = CountryCode.UK;

        public string Message { get; set; } = string.Empty;
    }
}
