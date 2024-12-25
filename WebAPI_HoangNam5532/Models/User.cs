using Microsoft.AspNetCore.Identity;

namespace WebAPI_HoangNam5532.Models
{
    public class User : IdentityUser
    {
        public string? Initials { get; set; }
        //User = IdentityUser + string Inititals 
    }
}
