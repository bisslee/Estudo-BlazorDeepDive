using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models
{
    public class Server
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Name must have a maximum of 50 characters")]
        [MinLength(3, ErrorMessage = "Name must have a minimum of 3 characters")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string? City { get; set; }
        public bool IsOnline { get; set; }

        public Server()
        {
            Random random = new Random();
            IsOnline = random.Next(0, 2) == 1;
        }
    }
}
