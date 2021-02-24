using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Identity;
namespace AuthenticationDemo.Persistence
{
    public class User : IdentityUser
    {
        [Required] public string FullName { get; set; }
    }
}