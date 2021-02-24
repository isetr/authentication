using System.ComponentModel.DataAnnotations;

namespace AuthenticationDemo.Models
{
    public record LoginModel
    (
        [Required(ErrorMessage = "User name is required!")] string UserName,
        [Required(ErrorMessage = "Password is required!")] string Password
    );
}