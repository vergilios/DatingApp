using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; } 

        [Required]   
        [StringLength(8,MinimumLength = 4, ErrorMessage = "Password must be between 4 and 8 chars")]
        public string Password { get; set; }  
    }
}