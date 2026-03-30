using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsSSO { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}