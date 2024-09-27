using System.ComponentModel.DataAnnotations;

namespace CampusShuttleAPI.Model.DTO
{
    public class ShuttleDTO
    {
        [Required]  // Ensures the field is not null
        [MaxLength(100)]  // Limits the length of the destination name
        public string Destination { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

    }
}
