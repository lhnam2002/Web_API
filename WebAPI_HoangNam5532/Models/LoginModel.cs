using System.ComponentModel.DataAnnotations;

namespace WebAPI_HoangNam5532.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
