using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetDev.Models
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [Required]
        public string Role { get; set; } // "Admin", "Proprietaire", "Client"


        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public class Admin : User
    {
        public Admin()
        {
            Role = "Admin";
        }
    }

    public class Proprietaire : User
    {
        public ICollection<House>? Houses { get; set; }

        public Proprietaire()
        {
            Role = "Proprietaire";
        }
    }

    public class Client : User
    {
        public ICollection<Reservation>? Reservations { get; set; }

        public Client()
        {
            Role = "Client";
        }
    }
}
