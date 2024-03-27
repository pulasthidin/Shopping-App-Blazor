using System.ComponentModel.DataAnnotations;

namespace MarketJunctionAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Username must be between 3 and 50 characters long.")]
        [MinLength(3, ErrorMessage = "Username must be between 3 and 50 characters long.")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Password must be at least 6 characters long.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }

        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }

        [StringLength(200)]
        public string LastName { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string Telephone { get; set; }

        [Required]
        public string Role { get; set; }

        // Additional properties can be added as needed
        // For example: roles, permissions, profile information, etc.
    }
}
