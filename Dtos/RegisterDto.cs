using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RegisterDto
    {
        // best way to add validation is to add it in the DTO level
        // [ApiController] automatically checks for validation on the DTO level and return  appropriate respone if it fails
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}